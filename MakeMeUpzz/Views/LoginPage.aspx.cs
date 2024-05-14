using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserRepository userRepo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PassTextBox.Text;

            User user = userRepo.GetUsers().FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "User not found";
                return;
            }
            else
            {
                if (user.UserPassword != password)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Invalid Password";
                    return;
                }
                else
                {
                    Session["user"] = user;

                    if (RememberCheckBox.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = user.UserID.ToString();
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);
                    }

                    if (Application["user_count"] == null)
                    {
                        Application["user_count"] = 1;
                    }
                    else
                    {
                        Application["user_count"] = (int)Application["user_count"] + 1;
                    }

                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void registerRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}