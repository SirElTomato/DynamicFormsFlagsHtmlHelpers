using DynamicForms.Lib;
using DynamicForms.Lib.Extensions;
using DynamicForms.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DynamicForms.Presentation.Mvc
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString EditorForPaymentField<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
            where TModel : PaymentFormViewModel
        {
            var model = (PaymentFormViewModel)html.ViewData.Model;
            var paymentType = model.PaymentType;
            var attributeOnProperty = GetFieldAttribute(expression);

            if (attributeOnProperty.PaymentTypes.HasFlag(paymentType.GetPaymentTypeFlags()))
            {
                return html.EditorFor(expression);
            }
            else
            {
                return new MvcHtmlString(string.Empty);
            }
        }

        public static RequiredForPaymentTypeAttribute GetFieldAttribute<TModel, TValue>(Expression<Func<TModel, TValue>> expression)
            where TModel : PaymentFormViewModel
        {
            var memberExpression = (MemberExpression)expression.Body;
            var member = memberExpression.Member as PropertyInfo;
            var attribute = (RequiredForPaymentTypeAttribute)member.GetCustomAttribute(typeof(RequiredForPaymentTypeAttribute));

            return attribute;
        }
    }
}
