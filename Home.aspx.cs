using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Linq;

public partial class Home : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Validating session
        if (Session["UserID"] == null || Session["IsStudent"] == null)
        {
            Response.Redirect("index.html", false);
            ApplicationInstance.CompleteRequest();
        }
        #endregion
        Session["ScenarioID"] = null;
        Session["HideComment"] = null;
        string decsription = @"A student or pupil is a learner or someone who attends an educational institution. In Britain those attending university are termed 
                                A student or pupil is a learner or someone who attends an educational institution. In Britain those attending university are termed 
                                A student or pupil is a learner or someone who attends an educational institution. In Britain those attending university are termed 
                                A student or pupil is a learner or someone who attends an educational institution. In Britain those attending university are termed ";
        if (!IsPostBack)
        {
            if (Convert.ToInt32(Session["IsStudent"]) == 1)
            {
                lblwelcome.Text = "Welcome Student :" + Session["UserName"];
                lblweldescp.Text = decsription;
            }
            else
            {
                lblwelcome.Text = "Welcome Admin :" + Session["UserName"];
                lblweldescp.Text = "";
                pnlAdmin.Visible = true;
                SetDashboardForAdmin();
            }

                
        }
    }


    public void SetDashboardForAdmin()
    {
        using (CellEntities context = new CellEntities())
        {
            var scenariocount = (from rs in context.Scenarios select rs.Name).ToList().Count();
            var contentcount = (from rs in context.Contents select rs.HeadingID).ToList().Count();
            var studentcount = (from rs in context.Accounts select rs.AccountId).ToList().Count();
            lblscenario.Text = @"Available no of scenario  " + scenariocount.ToString();
            lblcontent.Text = @"Available no of conent  " + contentcount.ToString();
            lblstudetn.Text = @"Available no of student  " + studentcount.ToString();
            
        };
    }



    protected void btnstartGame_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowScenarios.aspx", false);
        ApplicationInstance.CompleteRequest();
    }
}