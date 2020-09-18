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
 public partial class SpecificDlg : Form
 {
  public Cluster SpecificCluster { get; private set; }
  private List<Cluster> Already;
  private List<Cluster> Clusters;

  public SpecificDlg(in List<Cluster> clusters,in List<Cluster>already)
  {
   InitializeComponent();
   
   Clusters=clusters;
   Already=already;

   btnAbil.Click += new System.EventHandler(btnAbility_Click);
   btnBody.Click += new System.EventHandler(btnBody_Click);
   btnMelee.Click += new System.EventHandler(btnMelee_Click);
   btnMeleeSpec.Click += new System.EventHandler(btnMeleeSpec_Click);
   btnRange.Click += new System.EventHandler(btnRange_Click);
   btnRangeSpec.Click += new System.EventHandler(btnRangeSpec_Click);
   btnNano.Click += new System.EventHandler(btnNano_Click);
   btnExplore.Click += new System.EventHandler(btnExplore_Click);
   btnCombatHeal.Click += new System.EventHandler(btnCombatHeal_Click);
   btnTrade.Click += new System.EventHandler(btnTrade_Click);
   btnAC.Click += new System.EventHandler(btnAC_Click);
   btnMax.Click += new System.EventHandler(btnMax_Click);
   btnLegacy.Click += new System.EventHandler(btnLegacy_Click);

   c1.Width=180;
  }


 private void btnAbility_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Ability);
 }
 private void btnBody_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.BodyDef);
 }
 private void btnMelee_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Melee);
 }
 private void btnMeleeSpec_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.MeleeSpec);
 }
 private void btnRange_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Ranged);
 }
 private void btnRangeSpec_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.RangedSpec);
 }
 private void btnNano_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Nanos);
 }
 private void btnExplore_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Explore);
 }
 private void btnCombatHeal_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.CombatHeal);
 }
 private void btnTrade_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.TradeRepair);
 }
 private void btnAC_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.AC);
 }
 private void btnMax_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Max);
 }
 private void btnLegacy_Click(Object s, EventArgs e)
 {
  AddClusters(Cluster.ImprovementType.Legacy);
 }

 private void AddClusters(Cluster.ImprovementType cat)
 {
  String t;
  bool Found;

  list.Items.Clear();
  foreach(Cluster c in Clusters)
  {
    if (c.Category==cat)
    {
      t=c.ClusterName;
      Found=false;
      foreach(Cluster ac in Already)
      {
        if (c.ID==ac.ID) Found=true;
      }
      if (Found==true) t+=" *";
      list.Items.Add(new ClusterItem(c,t));
    }
  }
}


 private void btnOK_Click(object sender, EventArgs e)
 {
  ClusterItem item;
  if (list.SelectedItems.Count==0) 
   {
    MessageBox.Show("Select a cluster or click Cancel");
    return;
   }
  item=(ClusterItem)list.SelectedItems[0];
  SpecificCluster=item.ItemCluster;
  this.DialogResult=DialogResult.OK;
  this.Close();
 }

 private void btnCancel_Click(object sender, EventArgs e)
 {
  this.DialogResult=DialogResult.Cancel;
  this.Close();
 }

};

public class ClusterItem : ListViewItem
{
 public Cluster ItemCluster { get; private set; }
 public ClusterItem(Cluster c)
  {
   ItemCluster=c;
   Text=c.ClusterName;
  }
 public ClusterItem(Cluster c, String showText)
  {
   ItemCluster=c;
   Text=showText;
  }
};

public class ImplantItem : ListViewItem
{
 public Implant ItemImplant { get; private set; }
 public ImplantItem(Implant imp)
  {
   ItemImplant=imp;
   Text=imp.ImplantName;
  }
};

public class SortByName : System.Collections.IComparer
{
 public SortByName()
 {
 }
 public int Compare(object x, object y)
  {
   ListViewItem xi,yi;

   xi=(ListViewItem)x;
   yi=(ListViewItem)y;
   return String.Compare(xi.Text,yi.Text);
  }
}

}
