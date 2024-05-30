using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public static class StaticDataClass
    {
        public static int ID_profile = -1;

        public static void ShowProfileForm(object sender)
        {
            if (ID_profile == -1)
            {
                AuthorizeForm authorizeForm = new AuthorizeForm();
                authorizeForm.Show();
            }
            else
            {
                QuestionnaireForm questionnaireForm = new QuestionnaireForm();
                questionnaireForm.Show();

            }
            Form form = (Form)sender;
            form.Visible = false;
        }
    }
}
