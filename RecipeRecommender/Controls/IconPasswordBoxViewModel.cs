using Core;
using System.Security;
using System.Windows.Controls;

namespace RecipeRecommender
{
    /// <summary>
    /// Interaction logic for IconTextBox.xaml
    /// </summary>
    public partial class IconPasswordBoxViewModel : BaseControl<IconTextBoxViewModel>, IHavePassword
    {
        public IconPasswordBoxViewModel()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword => mPasswordBox.SecurePassword;
    }
}
