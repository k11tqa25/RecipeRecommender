using Core;
using System.Windows.Controls;

namespace RecipeRecommender
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();

            user1IconTextBox.ViewModel = new IconTextBoxViewModel() { TextBoxText = "User1", IconType = IconTextBoxIconType.User };

            user2IconTextBox.ViewModel = new IconTextBoxViewModel() { TextBoxText = "User2", IconType = IconTextBoxIconType.User };

            user1IconPasswordBox.ViewModel = new IconTextBoxViewModel() { TextBoxText = "PASSWORD", IconType = IconTextBoxIconType.Password };

            user2IconPasswordBox.ViewModel = new IconTextBoxViewModel() { TextBoxText = "PASSWORD", IconType = IconTextBoxIconType.Password };
        }
    }
}
