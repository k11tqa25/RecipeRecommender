namespace Core
{
    /// <summary>
    /// A view model for icon textbox
    /// </summary>
    public class IconTextBoxViewModel: BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The text of the icon textbox
        /// </summary>
        public string TextBoxText { get; set; }

        /// <summary>
        /// The icon type for the icon textbox
        /// </summary>
        public IconTextBoxIconType IconType { get; set; }

        #endregion

        #region Constructor

        public IconTextBoxViewModel()
        {

        }

        #endregion

    }
}
