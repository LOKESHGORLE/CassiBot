using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;

namespace UserPropertiesWindowAuth
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string WantedUser="";
            try
            {
                //userathtml.Text = Context.User.Identity;
                #region
                string UserNAmes = "";

                using (var context = new PrincipalContext(ContextType.Domain, "nmc-uk.net"))
                {
                    using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                    {
                        int cnt = 1;
                        foreach (var result in searcher.FindAll())
                        {
                            DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                            WantedUser += (string)de.Properties["givenName"].Value + "/";
                            //Console.WriteLine("First Name: " + de.Properties["givenName"].Value);
                            //Console.WriteLine("SAM account name   : " + de.Properties["samAccountName"].Value);
                            //Console.WriteLine("User principal name: " + de.Properties["userPrincipalName"].Value);
                            //Console.WriteLine();
                            //cnt++;
                        }
                        //UNAMe.Text = UserNAmes;
                        Email.Text = "akjhlghasdgeagrhtrhtrhtrhtrgh";
                        // Console.WriteLine("Total users: " + cnt);

                    }
                }
                #endregion
                IPrincipal p = Thread.CurrentPrincipal;
                IIdentity i = Thread.CurrentPrincipal.Identity;
                
                WantedUser += "UNbyGetCurrUser : " + WindowsIdentity.GetCurrent().Name + "<br/>UNbyUser : " + WindowsIdentity.GetCurrent().User;

                WantedUser += "<br/>UserByUserIdentity : " + User.Identity.Name + "";
                WantedUser += "<br/>HttpContext.Current.User : " + HttpContext.Current.User;
                WindowsIdentity user;
                user = HttpContext.Current.Request.LogonUserIdentity;
                WantedUser += "<br/> HttpContext.Current.Request.LogonUserIdentity : " + user;
                WantedUser += "<br/>" + "Thread.CurrentPrincipal.Identity Identity Name: " + i.Name + " <br/>Thread.CurrentPrincipal.Identity.Name :  " + p.Identity.Name;
                UNAMe.Text = WantedUser;
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message;
            }

        }
    }
}