using Core;

namespace RecipeRecommender
{
    public class IconTextBoxDesignModel: IconTextBoxViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of a design model
        /// </summary>
        public static IconTextBoxDesignModel Instance => new IconTextBoxDesignModel();

        #endregion

        #region Constructor

        public IconTextBoxDesignModel()
        {
            TextBoxText = "User N";
            IconType = IconTextBoxIconType.User;
        }
        
        #endregion
    }
}
