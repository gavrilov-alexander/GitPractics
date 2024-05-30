using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class StaticDataClass
    {
        public static int IDProfile = -1;

        public static int IDQuestionnaire = -1;

        public static string Email = "";

        public static bool IsAdmin = false;

        public static void ShowProfileForm(object sender)
        {
            /*QuestionnaireForm questionnaireForm = new QuestionnaireForm();
            questionnaireForm.Show();*/
            if (IDProfile == -1)
            {
                AuthorizeForm authorizeForm = new AuthorizeForm();
                authorizeForm.Show();
            }
            else if (IDQuestionnaire != -1)
            {
                QuestionnaireForm questionnaireForm = new QuestionnaireForm();
                questionnaireForm.Show();
            }
            else
            {
                QuestionnaireUpdateForm questionnaireUpdateForm = new QuestionnaireUpdateForm();
                questionnaireUpdateForm.Show();
            }
            Form form = (Form)sender;
            if (!(form is MainForm))
            {
                form.Close();
            }
        }
    }
}
