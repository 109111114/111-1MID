using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string[] s_id = new string[] { "tb_Num", "rbl_Phone", "txt_Phone", "dpl_City", "dpl_Area" };
            string[] s_type = new string[] { "保單號碼:", "通訊種類:", "通訊號碼:", "所在城市:", "所在區域:" };
            for (int i_ct = 0; i_ct < s_id.Length; i_ct++)
            {
                lb_Msg.Text += s_type[i_ct] + " " + Request.Form.Get(s_id[i_ct]) + "<br />";
            }
        }
    }
}