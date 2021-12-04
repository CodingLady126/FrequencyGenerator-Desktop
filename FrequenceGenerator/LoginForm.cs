using System;
using System.Threading;
using System.Windows.Forms;


namespace FrequenceGenerator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            CenterToScreen();
            panel_register.Visible = false;

            ActiveControl = txtEmail;

            preLoader1.Visible = false;
            picLoader.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //
            if (txtEmail.Text == "")
            {
                MessageBox.Show(Variables.StrEmailValidate);
                ActiveControl = txtEmail;
            }else if (txtPassword.Text == "")
            {
                MessageBox.Show(Variables.StrPasswordValidate);
                ActiveControl = txtPassword;
            }
            else
            {
                try
                {
                    Thread threadInput = new Thread(DisplayData);
                    threadInput.Start();
                }
                catch (Exception exception)
                {
                    DisplayError(exception);
                }
            }
        }
        

        private async void btnRegister1_Click(object sender, EventArgs e)
        {
            if (txtEmail1.Text == "")
            {
                MessageBox.Show(Variables.StrEmailValidate);
                ActiveControl = txtEmail1;
            }else if (txtPassword1.Text == "")
            {
                MessageBox.Show(Variables.StrPasswordValidate);
                ActiveControl = txtPassword1;
            }else if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text != txtPassword1.Text)
            {
                MessageBox.Show(Variables.StrConfirmPasswordValidate);
                ActiveControl = txtConfirmPassword;
            }else
            {
                var user = await FirebaseUser.AddUser(txtEmail1.Text, txtPassword1.Text);
                if (user)
                {
                    Thread threadInput = new Thread(DisplayData);
                    threadInput.Start();
                }
                else
                {
                    MessageBox.Show(Variables.StrSignupFailed, Variables.StrOk);
                }
            }
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_register.Visible = false;
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_register.Visible = true;
        }
        
        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = true;
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = false;
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }
        
        private async void DisplayData()
        {
            SetLoading(true);
            
            Thread.Sleep(4000);
            //call GetUser function which we define in Firebase helper class    
            var user = await FirebaseUser.GetUser(txtEmail.Text);    

            this.Invoke((MethodInvoker) delegate
            {
                //firebase return null values if user data not found in database    
                if (user != null)
                {
                    if (txtEmail.Text == user.Email && txtPassword.Text == user.Password)    
                    {   
                        Hide();
                        MainForm mForm = new MainForm();
                        mForm.Show(); 
                    }    
                    else    
                        MessageBox.Show(Variables.StrCorrectInfoValidate, Variables.StrOk); 
                }
                       
                else    
                    MessageBox.Show(Variables.StrUserNotFound, Variables.StrOk);
            });
    
            // Do other operations...

            SetLoading(false);
        }
        
        private void DisplayError(Exception ex)
        {
            MessageBox.Show(Variables.StrErrorException + ex.Message);
        }
    }
}