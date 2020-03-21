using Core;
using System;
using System.Globalization;

namespace RecipeRecommender
{
    /// <summary>
    /// A converter that takes in a <see cref="IconTextBoxIconType"/> and convert to the icon
    /// </summary>
    public class IconTypeToIconConverter : BaseValueConverter<IconTypeToIconConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((IconTextBoxIconType)value)
            {
                case IconTextBoxIconType.User:
                    return "\uf007";

                case IconTextBoxIconType.Password:
                    return "\uf13e";

                default:
                    return "";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
