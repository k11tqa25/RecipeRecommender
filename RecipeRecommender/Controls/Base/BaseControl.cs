using Core;
using System.Windows.Controls;

namespace RecipeRecommender
{
    public class BaseControl : UserControl
    {
        public BaseControl()
        {

        }
    }

    /// <summary>
    /// A base page with added ViewModel support
    /// </summary>
    public class BaseControl<VM> : BaseControl
        where VM : BaseViewModel, new()
    {

        #region Private Member
        /// <summary>
        /// The view model associated with this page
        /// </summary>
        private VM mViewModel;
        #endregion

        #region Public Properties

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => mViewModel;
            set
            {
                // If nothing has changed, then
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set the data context for this page
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        public BaseControl() : base()
        {
            // Create a default view model
            this.ViewModel = new VM();
        }

        #endregion
    }
}
