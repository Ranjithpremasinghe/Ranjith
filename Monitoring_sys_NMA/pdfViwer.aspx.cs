﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Monitoring_sys_NMA
{
    public partial class pdfViwer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"100%\" height=\"920px\">";
            //embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            //embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            //embed += "</object>";
            //string filepath = null;
            //Literal1.Text = string.Format(embed, ResolveUrl("~/Documents/NHQ 071537.docx"));
        }

        protected void FetchButton_Click(object sender, EventArgs e)
        {

        }
    }
}