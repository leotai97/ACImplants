using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOImplants
{
  public partial class ShoppingDlg : Form
  {
   public ListView Implants { get => listImplants; }
   public ListView Shining { get => listShining; }
   public ListView Bright { get => listBright; }
   public ListView Faded { get => listFaded; }
   private MainWnd Wnd;


    public ShoppingDlg(in MainWnd wnd)
    {
     InitializeComponent();
     Wnd=wnd;
    }
    protected override void OnResize(EventArgs e)
    {
     base.OnResize(e);
     int g=listImplants.Left;
     int tw=ClientSize.Width-(g*5);

     listImplants.Top=tool.Height+2;
     listImplants.Left=g;
     listImplants.Width=tw/4;
     listImplants.Height=ClientSize.Height-(tool.Height+8);;
     listFaded.Top=listImplants.Top;
     listFaded.Left=listImplants.Left+listImplants.Width+g;
     listFaded.Width=tw/4;
     listFaded.Height=listImplants.Height;
     listBright.Top=listImplants.Top;
     listBright.Left=listFaded.Left+listFaded.Width+g;
     listBright.Width=tw/4;
     listBright.Height=listImplants.Height;
     listShining.Top=listImplants.Top;
     listShining.Left=listBright.Left+listBright.Width+g;
     listShining.Width=tw/4;
     listShining.Height=listImplants.Height;

     I1.Width=listImplants.ClientSize.Width-1;
     s1.Width=listShining.ClientSize.Width-1;
     b1.Width=listBright.ClientSize.Width-1;
     f1.Width=listFaded.ClientSize.Width-1;

    }

    private void btnClipboard_Click(object sender, EventArgs e)
    {
     Cluster c;
     List<String>c1,c2,c3,c4;
     String[,] Array=new string[4, 15];
     c1=new List<string>();
     c2=new List<string>();
     c3=new List<string>();
     c4=new List<string>();
     String s;
     int i, max;

    // First do the shopping list
   
     s=Wnd.Text+"\r\n\r\n";
     s+="Shopping List\r\n\r\n";

     c1.Add("Implants");
     c1.Add("--------");
     c2.Add("Faded");
     c2.Add("-------");
     c3.Add("Bright");
     c3.Add("------");
     c4.Add("Shining");
     c4.Add("-----");
 

     foreach(ImplantItem item in listImplants.Items)
      {
       c1.Add(item.Text);
      }
     foreach(ClusterItem item in listFaded.Items)
      {
       c2.Add(item.Text);
      }
     foreach(ClusterItem item in listBright.Items)
      {
       c3.Add(item.Text);
      }
     foreach(ClusterItem item in listShining.Items)
      {
       c4.Add(item.Text);
      }
     
      c1=Pad(c1);
      c2=Pad(c2);
      c3=Pad(c3);
      c4=Pad(c4);
      
      max=c1.Count;
      if (c2.Count>max) max=c2.Count;
      if (c3.Count>max) max=c3.Count;
      if (c4.Count>max) max=c4.Count;

      for (i=0;i<max;i++)
       {
        if (i<c1.Count) s += c1[i]; else s+=new String(' ',c1[0].Length);
        s+="\t";
        if (i<c2.Count) s += c2[i]; else s+=new String(' ',c2[0].Length);
        s+="\t";
        if (i<c3.Count) s += c3[i]; else s+=new String(' ',c3[0].Length); 
        s+="\t";
        if (i<c4.Count) s += c4[i]; else s+=new String(' ',c4[0].Length);
        s+="\r\n";
       }

     s+="\r\nImplant Specifications\r\n\r\n";

      // 2nd do the implants as shown on MainWnd

     c1.Clear();
     c1.Add("Implants   ");
     c1.Add("--------   ");
     c1.Add(Wnd.Head.ImplantName.PadRight(11));
     c1.Add(Wnd.Eye.ImplantName.PadRight(11));
     c1.Add(Wnd.Ear.ImplantName.PadRight(11));
     c1.Add(Wnd.Chest.ImplantName.PadRight(11));
     c1.Add(Wnd.RArm.ImplantName.PadRight(11));
     c1.Add(Wnd.RWrist.ImplantName.PadRight(11));
     c1.Add(Wnd.RHand.ImplantName.PadRight(11));
     c1.Add(Wnd.LArm.ImplantName.PadRight(11));
     c1.Add(Wnd.LWrist.ImplantName.PadRight(11));
     c1.Add(Wnd.LHand.ImplantName.PadRight(11));
     c1.Add(Wnd.Waist.ImplantName.PadRight(11));
     c1.Add(Wnd.Leg.ImplantName.PadRight(11));
     c1.Add(Wnd.Feet.ImplantName.PadRight(11));
     
     c2.Clear();
     c2.Add("Faded");
     c2.Add("-------");
     foreach(ComboBox cbo in Wnd.FadedCBOs)
      {
       if (cbo.SelectedIndex>=0) c=(Cluster)cbo.SelectedItem; else c=null;
       if (c!=null) c2.Add(c.ClusterName); else c2.Add("---");
      }
      
     c3.Clear();
     c3.Add("Bright");
     c3.Add("-------");
     foreach(ComboBox cbo in Wnd.BrightCBOs)
      {
       if (cbo.SelectedIndex>=0) c=(Cluster)cbo.SelectedItem; else c=null;
       if (c!=null) c3.Add(c.ClusterName); else c3.Add("---");
      }

     c4.Clear();
     c4.Add("Shining");
     c4.Add("-----");
     foreach(ComboBox cbo in Wnd.ShiningCBOs)
      {
       if (cbo.SelectedIndex>=0) c=(Cluster)cbo.SelectedItem; else c=null;
       if (c!=null) c4.Add(c.ClusterName); else c4.Add("---");
      }

      c1=Pad(c1);
      c2=Pad(c2);
      c3=Pad(c3);
      c4=Pad(c4);

    for (i=0;i<15;i++) // no chance of rows being empty 
      {
      if (i<c1.Count) s += c1[i]; else s+=new String(' ',c1[0].Length);
      s+="\t";
      if (i<c2.Count) s += c2[i]; else s+=new String(' ',c2[0].Length);
      s+="\t";
      if (i<c3.Count) s += c3[i]; else s+=new String(' ',c3[0].Length); 
      s+="\t";
      if (i<c4.Count) s += c4[i]; else s+=new String(' ',c4[0].Length);
      s+="\r\n";
      }
   
     Clipboard.SetText(s);  
     this.Text+=" -- copied to clipboard";
    }

   private List<String> Pad(List<String> items)
   {
    List<String>output=new List<string>();
    int max=0;
    foreach(String s in items)
     {
      if (s.Length>max) max=s.Length;
     }
    foreach(String s in items)
    {
     output.Add(s.PadRight(max,' '));
    } 
    return output;
   }



  };
}
