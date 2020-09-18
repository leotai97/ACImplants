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
 public partial class MainWnd : Form
 {
  public List<Implant>Implants;
  public List<Cluster>Clusters;
  public List<ComboBox> ShiningCBOs;
  public List<ComboBox> BrightCBOs;
  public List<ComboBox> FadedCBOs;
  public String LastPath;

  public List<Cluster>SelectedSpecifics;

  public Implant Head=new Implant(Implant.enumImplant.Head, "Head");
  public Implant Eye=new Implant(Implant.enumImplant.Eye, "Eye");
  public Implant Ear=new Implant(Implant.enumImplant.Ear, "Ear");
  public Implant Chest=new Implant(Implant.enumImplant.Chest, "Chest");
  public Implant RArm=new Implant(Implant.enumImplant.RArm, "Right Arm");
  public Implant RWrist=new Implant(Implant.enumImplant.RWrist, "Right Wrist");
  public Implant RHand=new Implant(Implant.enumImplant.RHand, "Right Hand");
  public Implant LArm=new Implant(Implant.enumImplant.LArm, "Left Arm");
  public Implant LWrist=new Implant(Implant.enumImplant.LWrist, "Left Wrist");
  public Implant LHand=new Implant(Implant.enumImplant.LHand, "Left Hand");
  public Implant Waist=new Implant(Implant.enumImplant.Waist, "Waist");
  public Implant Leg=new Implant(Implant.enumImplant.Leg, "Legs");
  public Implant Feet=new Implant(Implant.enumImplant.Feet, "Feet");

  public String LoadedFile { get; private set; }

  public MainWnd()
  {
   InitializeComponent();
   LoadClusters();
   LoadComboBoxes();
   LoadComboBoxTypes();
   ShiningCBOs=new List<ComboBox>(){ cboHeadShine, cboEyeShine, cboEarShine, cboChestShine, cboRArmShine, cboRWristShine, cboRHandShine, cboLArmShine, cboLWristShine, cboLHandShine, cboWaistShine, cboLegShine,cboFeetShine};
   BrightCBOs=new List<ComboBox>(){ cboHeadBright, cboEyeBright, cboEarBright, cboChestBright, cboRArmBright, cboRWristBright, cboRHandBright, cboLArmBright, cboLWristBright, cboLHandBright, cboWaistBright, cboLegBright,cboFeetBright};
   FadedCBOs=new List<ComboBox>(){ cboHeadFade, cboEyeFade, cboEarFade, cboChestFade, cboRArmFade, cboRWristFade, cboRHandFade, cboLArmFade, cboLWristFade, cboLHandFade, cboWaistFade, cboLegFade,cboFeetFade};
   SelectedSpecifics=new List<Cluster>();
   LoadedFile="";
   LastPath="";

   foreach (ComboBox cbo in ShiningCBOs)
    {
     cbo.KeyDown+=new System.Windows.Forms.KeyEventHandler(this.OnCBOKey);
     cbo.DrawItem+=new DrawItemEventHandler(OnCBODrawItem);
     cbo.DrawMode= DrawMode.OwnerDrawFixed;
    }
   foreach (ComboBox cbo in BrightCBOs)
    {
     cbo.KeyDown+=new System.Windows.Forms.KeyEventHandler(this.OnCBOKey);
     cbo.DrawItem+=new DrawItemEventHandler(OnCBODrawItem);
     cbo.DrawMode= DrawMode.OwnerDrawFixed;
    }
   foreach (ComboBox cbo in FadedCBOs)
    {
     cbo.KeyDown+=new System.Windows.Forms.KeyEventHandler(this.OnCBOKey);
     cbo.DrawItem+=new DrawItemEventHandler(OnCBODrawItem);
     cbo.DrawMode= DrawMode.OwnerDrawFixed;
    }

  }

 private void AddShining(ComboBox cbo, Implant imp)
 {
  foreach(Cluster c in Clusters)
  {
   if (c.Shining.ImplantType==imp.ImplantType)
    cbo.Items.Add(c);
  }
 }

 private void AddBright(ComboBox cbo, Implant imp)
 {
  foreach(Cluster c in Clusters)
  {
   if (c.Bright.ImplantType==imp.ImplantType)
    cbo.Items.Add(c);
  }
 }

 private void AddFaded(ComboBox cbo, Implant imp)
 {
  foreach(Cluster c in Clusters)
  {
   if (c.Faded.ImplantType==imp.ImplantType)
    cbo.Items.Add(c);
  }
 }

 private void LoadComboBoxes()
 {
  AddShining(cboHeadShine,Head);
  AddBright(cboHeadBright,Head);
  AddFaded(cboHeadFade,Head);

  AddShining(cboEyeShine,Eye);
  AddBright(cboEyeBright,Eye);
  AddFaded(cboEyeFade,Eye);

  AddShining(cboEarShine,Ear);
  AddBright(cboEarBright,Ear);
  AddFaded(cboEarFade,Ear);

  AddShining(cboChestShine,Chest);
  AddBright(cboChestBright,Chest);
  AddFaded(cboChestFade,Chest);

  AddShining(cboRArmShine,RArm);
  AddBright(cboRArmBright,RArm);
  AddFaded(cboRArmFade,RArm);

  AddShining(cboRWristShine,RWrist);
  AddBright(cboRWristBright,RWrist);
  AddFaded(cboRWristFade,RWrist);

  AddShining(cboRHandShine,RHand);
  AddBright(cboRHandBright,RHand);
  AddFaded(cboRHandFade,RHand);

  AddShining(cboLArmShine,LArm);
  AddBright(cboLArmBright,LArm);
  AddFaded(cboLArmFade,LArm);

  AddShining(cboLWristShine,LWrist);
  AddBright(cboLWristBright,LWrist);
  AddFaded(cboLWristFade,LWrist);

  AddShining(cboLHandShine,LHand);
  AddBright(cboLHandBright,LHand);
  AddFaded(cboLHandFade,LHand);

  AddShining(cboWaistShine,Waist);
  AddBright(cboWaistBright,Waist);
  AddFaded(cboWaistFade,Waist);

  AddShining(cboLegShine,Leg);
  AddBright(cboLegBright,Leg);
  AddFaded(cboLegFade,Leg);

  AddShining(cboFeetShine,Feet);
  AddBright(cboFeetBright,Feet);
  AddFaded(cboFeetFade,Feet);
 }

 // ---------------------------------------------------------------------------

  private void btnClear_Click(object sender, EventArgs e)
  {
   ClearCBOs();
  }

  private void btnShoppingList_Click(object sender, EventArgs e)
  {
   ShoppingDlg dlg=new ShoppingDlg(this);
   Cluster c;

   foreach (ComboBox cbo in ShiningCBOs)
    {
     if (cbo.SelectedIndex>=0) 
      {
       c=(Cluster)cbo.SelectedItem;
       dlg.Shining.Items.Add(new ClusterItem(c));
       AddImplant(dlg.Implants,(Implant)cbo.Tag);
      }
    }
   foreach (ComboBox cbo in BrightCBOs)
    {
     if (cbo.SelectedIndex>=0) 
      {
       c=(Cluster)cbo.SelectedItem;
       dlg.Bright.Items.Add(new ClusterItem(c));
       AddImplant(dlg.Implants,(Implant)cbo.Tag);
      }
    }
   foreach (ComboBox cbo in FadedCBOs)
    {
     if (cbo.SelectedIndex>=0) 
      {
       c=(Cluster)cbo.SelectedItem;
       dlg.Faded.Items.Add(new ClusterItem(c));
       AddImplant(dlg.Implants,(Implant)cbo.Tag);
      }
    }
   dlg.Implants.ListViewItemSorter=new SortByName();
   dlg.Implants.Sort();
   dlg.Shining.ListViewItemSorter=new SortByName();
   dlg.Shining.Sort();
   dlg.Bright.ListViewItemSorter=new SortByName();
   dlg.Bright.Sort();
   dlg.Faded.ListViewItemSorter=new SortByName();
   dlg.Faded.Sort();
   dlg.ShowDialog();
  }

  private void AddImplant(in ListView list, Implant imp)
  {
   bool Found=false;
   foreach(ImplantItem item in list.Items)
    {
     if (imp.ImplantType==item.ItemImplant.ImplantType) Found=true;
    }
   if (Found==false)
     list.Items.Add(new ImplantItem(imp));
  }

  private void btnSet_Click(object sender, EventArgs e)
  {
   SpecificDlg dlg=new SpecificDlg(Clusters, SelectedSpecifics);
   DialogResult dr=dlg.ShowDialog();
   Cluster c;
   int i;

   if (dr==DialogResult.OK)
    {
     SelectedSpecifics.Add(dlg.SpecificCluster);
     foreach (ComboBox cbo in ShiningCBOs)
      {
       if (cbo.SelectedIndex==-1)
        {
         for(i=0;i<cbo.Items.Count;i++)
          {
           c=(Cluster)cbo.Items[i];
           if (c.ID==dlg.SpecificCluster.ID)
             cbo.SelectedIndex=i;
          } 
        }
      }
     foreach (ComboBox cbo in BrightCBOs)
      {
       if (cbo.SelectedIndex==-1)
        {
         for(i=0;i<cbo.Items.Count;i++)
          {
           c=(Cluster)cbo.Items[i];
           if (c.ID==dlg.SpecificCluster.ID)
             cbo.SelectedIndex=i;
          } 
        }
      }
     foreach (ComboBox cbo in FadedCBOs)
      {
       if (cbo.SelectedIndex==-1)
        {
         for(i=0;i<cbo.Items.Count;i++)
          {
           c=(Cluster)cbo.Items[i];
           if (c.ID==dlg.SpecificCluster.ID)
             cbo.SelectedIndex=i;
          } 
        }
      }
    }
   dlg.Dispose();
  } 

  private void btnLoad_Click(object sender, EventArgs e)
  {
   OpenFileDialog dlg=new OpenFileDialog();
   DialogResult dr;

   dlg.Title="AO Implants Load File";
   dlg.Filter="Character File (*.aof)|*.aof";
   dlg.CheckPathExists=true;
   dlg.CheckFileExists=true;
   if (LastPath.Length>0) dlg.InitialDirectory=LastPath;

   dr=dlg.ShowDialog();
   if (dr== DialogResult.OK)
   {
    if (LoadCharacter(dlg.FileName)==true)
     {
      LoadedFile=dlg.FileName;
      LastPath=System.IO.Path.GetDirectoryName(dlg.FileName);
      this.Text="AO Implants -- "+dlg.FileName;
     }
   }
   dlg.Dispose();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   DialogResult dr;
   String file="";

   if (LoadedFile.Length>0)
    {
     dr=MessageBox.Show("Save to "+LoadedFile+" ?","Save Implant Design", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
     switch(dr)
      {
       case DialogResult.Yes: file=LoadedFile; break;
       case DialogResult.Cancel: return; 
      }
    }
   if (file.Length==0)
    {
     SaveFileDialog dlg=new SaveFileDialog();
     dlg.Title="AO Implants Load File";
     dlg.Filter="Character File (*.aof)|*.aof";
     dlg.CheckPathExists=true;
     if (LastPath.Length>0) dlg.InitialDirectory=LastPath;
     dr=dlg.ShowDialog();
     if (dr==DialogResult.OK)
      {
       file=dlg.FileName;
       LastPath=System.IO.Path.GetDirectoryName(dlg.FileName);
      }
     dlg.Dispose();
    }
   if (file.Length==0)
     return;
   SaveCharacter(file); 
  }

  private bool SaveCharacter(String file)
  {
   System.IO.TextWriter write;
   
   try
    {
     write=new System.IO.StreamWriter(file,false);
    }
   catch
    {
     MessageBox.Show("Failed to save to file " + file);
     return false;
    }

   write.Write(SaveCBO(cboHeadShine, cboHeadBright,cboHeadFade) + "\r");
   write.Write(SaveCBO(cboEyeShine, cboEyeBright,cboEyeFade) + "\r");
   write.Write(SaveCBO(cboEarShine, cboEarBright,cboEarFade) + "\r");
   write.Write(SaveCBO(cboChestShine, cboChestBright,cboChestFade) + "\r");
   write.Write(SaveCBO(cboRArmShine, cboRArmBright,cboRArmFade) + "\r");
   write.Write(SaveCBO(cboRWristShine, cboRWristBright,cboRWristFade) + "\r");
   write.Write(SaveCBO(cboRHandShine, cboRHandBright,cboRHandFade) + "\r");
   write.Write(SaveCBO(cboLArmShine, cboLArmBright,cboLArmFade) + "\r");
   write.Write(SaveCBO(cboLWristShine, cboLWristBright,cboLWristFade) + "\r");
   write.Write(SaveCBO(cboLHandShine, cboLHandBright,cboLHandFade) + "\r");
   write.Write(SaveCBO(cboWaistShine, cboWaistBright,cboWaistFade) + "\r");
   write.Write(SaveCBO(cboLegShine, cboLegBright,cboLegFade) + "\r");
   write.Write(SaveCBO(cboFeetShine, cboFeetBright,cboFeetFade) + "\r");
   write.Close(); 
   write.Dispose();
   return true;
  }

  private String SaveCBO(ComboBox s, ComboBox b, ComboBox f) 
  {
   Cluster c;
   int si, bi, fi;

   if (s.SelectedIndex>=0)
    {
     c=(Cluster)s.SelectedItem;
     si=c.ID;
    }
   else  
     si=-1;

   if (b.SelectedIndex>=0)
    {
     c=(Cluster)b.SelectedItem;
     bi=c.ID;
    }
   else  
     bi=-1;

   if (f.SelectedIndex>=0)
    {
     c=(Cluster)f.SelectedItem;
     fi=c.ID;
    }
   else  
     fi=-1;

   return si.ToString()+","+bi.ToString()+","+fi.ToString();
  }

  private bool LoadCharacter(String file)
  {
  System.IO.TextReader read;
  String [] Parts;
  String all;
  bool err;
  int [] v;
  int i;

  try  
  {
  read=new System.IO.StreamReader(file);
  }
  catch 
  {
   MessageBox.Show("Failed open file " + file);
   return false;
  }
  all=read.ReadToEnd();
  read.Close();
  if (all.Length==0) return false;

  Parts=all.Split('\r');
  
  ClearCBOs();
  i=0;

   err=false;

  if (Extract(Parts[i++],out v)==false) err = true; else LoadHead(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadEye(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadEar(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadChest(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadRArm(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadRWrist(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadRHand(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadLArm(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadLWrist(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadLHand(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadWaist(v);
  if (Extract(Parts[i++],out v)==false) err = true; else LoadLeg(v);
  if (Extract(Parts[i],out v)==false)   err = true; else LoadFeet(v); 

  if (err==true)
   {
    MessageBox.Show("Bad file format found in file "+file);
    return false;
   }
  return true;
  }

private bool Extract(String s, out int [] v)
{
 String [] sv=s.Split(',');
 int i;

 v=new int[3];
 if (sv.Length != 3) return false;
 for(i=0;i<3;i++)
  {
   if (int.TryParse(sv[i],out v[i])==false) return false;
  }
 return true;
}

private void ClearCBOs()
{
 ComboBox cbo;

 SelectedSpecifics.Clear();
 this.Text="AO Implants";

 foreach(Control c in Controls)
  {
   if (c.Name.Substring(0,3)=="cbo")
    {
     cbo=(ComboBox)c;
     cbo.SelectedIndex=-1;
    }
  }
}

private void SetCBO(ComboBox cbo, int v)
{
 Cluster c;
 int i;

 if (v==-1) 
  {
   cbo.SelectedIndex=-1;
   return;
  }

 for(i=0;i<cbo.Items.Count;i++)
  {
   c=(Cluster)cbo.Items[i];
  if (c.ID==v)
   {
    cbo.SelectedIndex=i;
    return;
   }
  }
 throw new Exception("Didn't find value v in combobox");
}

private void LoadHead(int[] s)
{
 SetCBO(cboHeadShine,s[0]);
 SetCBO(cboHeadBright,s[1]);
 SetCBO(cboHeadFade,s[2]);
}
private void LoadEye(int[] s)
{
 SetCBO(cboEyeShine,s[0]);
 SetCBO(cboEyeBright,s[1]);
 SetCBO(cboEyeFade,s[2]);
}
private void LoadEar(int[] s)
{
 SetCBO(cboEarShine,s[0]);
 SetCBO(cboEarBright,s[1]);
 SetCBO(cboEarFade,s[2]);
}
private void LoadChest(int[] s)
{
 SetCBO(cboChestShine,s[0]);
 SetCBO(cboChestBright,s[1]);
 SetCBO(cboChestFade,s[2]);
}
private void LoadRArm(int[] s)
{
 SetCBO(cboRArmShine,s[0]);
 SetCBO(cboRArmBright,s[1]);
 SetCBO(cboRArmFade,s[2]);
}
private void LoadRWrist(int[] s)
{
 SetCBO(cboRWristShine,s[0]);
 SetCBO(cboRWristBright,s[1]);
 SetCBO(cboRWristFade,s[2]);
}
private void LoadRHand(int[] s)
{
 SetCBO(cboRHandShine,s[0]);
 SetCBO(cboRHandBright,s[1]);
 SetCBO(cboRHandFade,s[2]);
}
private void LoadLArm(int[] s)
{
 SetCBO(cboLArmShine,s[0]);
 SetCBO(cboLArmBright,s[1]);
 SetCBO(cboLArmFade,s[2]);
}
private void LoadLWrist(int[] s)
{
 SetCBO(cboLWristShine,s[0]);
 SetCBO(cboLWristBright,s[1]);
 SetCBO(cboLWristFade,s[2]);
}
private void LoadLHand(int[] s)
{
 SetCBO(cboLHandShine,s[0]);
 SetCBO(cboLHandBright,s[1]);
 SetCBO(cboLHandFade,s[2]);
}
private void LoadWaist(int[] s)
{
 SetCBO(cboWaistShine,s[0]);
 SetCBO(cboWaistBright,s[1]);
 SetCBO(cboWaistFade,s[2]);
}
private void LoadLeg(int[] s)
{
 SetCBO(cboLegShine,s[0]);
 SetCBO(cboLegBright,s[1]);
 SetCBO(cboLegFade,s[2]);
}
private void LoadFeet(int[] s)
{
 SetCBO(cboFeetShine,s[0]);
 SetCBO(cboFeetBright,s[1]);
 SetCBO(cboFeetFade,s[2]);
}

private void LoadComboBoxTypes()
{
 ComboBox c;
 foreach(Control ctrl in Controls)
  {
   if ( ctrl is ComboBox)
    {
     c=(ComboBox)ctrl;
     SetTag(c,"cboHead",Head);
     SetTag(c,"cboEye",Eye);
     SetTag(c,"cboEar",Ear);
     SetTag(c,"cboChest",Chest);
     SetTag(c,"cboRArm",RArm);
     SetTag(c,"cboRWrist",RWrist);
     SetTag(c,"cboRHand",RHand);
     SetTag(c,"cboLArm",LArm);
     SetTag(c,"cboLWrist",LWrist);
     SetTag(c,"cboLHand",LHand);
     SetTag(c,"cboWaist",Waist);
     SetTag(c,"cboLeg",Leg);
     SetTag(c,"cboFeet",Feet);   
    }
  }
}

private void SetTag(ComboBox cbo, String name, Implant imp)
{
 if (cbo.Name.Length<name.Length) return;
 if (cbo.Name.Substring(0, name.Length)==name)
   cbo.Tag=imp;
}

private void LoadClusters()
 {
  Clusters=new List<Cluster>();
  Clusters.Add(new Cluster("1h Blunt", RArm, RWrist, RHand, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("1h Edged", RArm, RWrist, RHand, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("2h Blunt", RArm, RWrist, Chest, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("2h Edged", RArm, RWrist, Waist, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Adventuring", Leg,Waist,Chest, Cluster.ImprovementType.Explore));
  Clusters.Add(new Cluster("Agility",Leg,Feet,Waist, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Aimed Shot",Eye,RWrist,RHand, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Assault Rif", RArm,RHand,Eye, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Bio Metamor",Head,Chest,Waist, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Body Dev",Chest,Waist,Leg, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Bow",RArm,LArm,Eye, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Bow Spec Att",Head,RHand,RWrist, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Brawling",LArm,RArm,Waist, Cluster.ImprovementType.MeleeSpec));
  Clusters.Add(new Cluster("Break & Entry",RArm,LArm,Chest, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Burst", RArm,RWrist,LArm, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Chemical AC",Waist, RArm,LArm, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Chemistry",Head,Eye,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Cold AC", Waist,RHand,LHand, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Comp Lit",Head,Eye,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Concealment",Feet,Ear,Eye, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Dimach",Chest,Head,Waist, Cluster.ImprovementType.MeleeSpec));
  Clusters.Add(new Cluster("Disease AC",Head,Leg,Chest, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Dodge Rng",Leg,Feet,Waist, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Duck Exp", Leg,Waist,Feet, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Elec Engi",Eye,Head,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Energy AC",Chest,Leg,Waist, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Evade-ClsC",Feet,Leg,Waist, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Fast Attack",LHand,	RHand,RArm, Cluster.ImprovementType.MeleeSpec));
  Clusters.Add(new Cluster("Fire AC",Waist,LHand,RHand, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("First Aid",Head,RHand,LHand, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Fling Shot",RArm,RHand,RWrist, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Full Auto",RArm,RWrist,Waist, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Grenade",RArm,Eye,RHand, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Heavy Weapons",RArm,Eye,RHand, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Imp/Proj AC",Leg,Chest,Waist, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Intelligence",Head,Eye,Ear, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Map Nav",Eye,Head,Ear, Cluster.ImprovementType.Legacy));
  Clusters.Add(new Cluster("Martial Arts",RHand,Feet,LHand, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Matter Crea",	Head,RHand,Eye, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Matt Metam",Head,Chest,LArm, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Max Health",Chest,Waist,Leg, Cluster.ImprovementType.Max));
  Clusters.Add(new Cluster("Max Nano",Head,Waist,Chest, Cluster.ImprovementType.Max));
  Clusters.Add(new Cluster("Mech Engi",Head,Eye,RArm, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Melee Energy",Head,LWrist,RWrist, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Melee Init",Feet,Leg,Waist, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Melee AC",Chest,Waist,Leg, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("MG/SMG",RArm,RHand,Chest, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Multi Melee",LWrist,Eye,RWrist, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Multi Ranged",LWrist,RWrist,Eye, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("NanoC Init",Head,Eye,Chest, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Nano Pool",Chest,Head,Waist, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Nano Program",Head,Eye,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Nano Resist",Head,RWrist,LWrist, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Parry(Deflect)",RWrist,LWrist,RArm, Cluster.ImprovementType.BodyDef));
  Clusters.Add(new Cluster("Perception",Ear,Eye,Head, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Pharma Tech",Head,Eye,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Physic Init",Feet,RArm,LArm, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Piercing",RArm,LArm,Waist, Cluster.ImprovementType.Melee));
  Clusters.Add(new Cluster("Pistol",RWrist,RHand,Eye, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Psychic",Head,Chest,Ear, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Psycho Modi",Head,Eye,Ear, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Psychology",Head,Ear,Eye, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Quantum FT",Head,Eye,RHand, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Radiation AC",Waist,LArm,RArm, Cluster.ImprovementType.AC));
  Clusters.Add(new Cluster("Ranged Energy",Head,Eye,LHand, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Ranged Init",RWrist,Head,RHand, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Rifle",Eye,RWrist,LWrist, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Riposte",RWrist,LWrist,RArm, Cluster.ImprovementType.MeleeSpec));
  Clusters.Add(new Cluster("Run Speed",RWrist,LWrist,Leg, Cluster.ImprovementType.Explore));
  Clusters.Add(new Cluster("Sense",Chest,Waist,Head, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Sensory Imp",Head,Eye,Chest, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Sharp Object",RWrist,RHand,Eye, Cluster.ImprovementType.RangedSpec));
  Clusters.Add(new Cluster("Shotgun",RArm,RHand,Waist, Cluster.ImprovementType.Ranged));
  Clusters.Add(new Cluster("Sneak Attack",Feet,RWrist,Eye, Cluster.ImprovementType.MeleeSpec));
  Clusters.Add(new Cluster("Stamina",Chest,Leg,Waist, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Strength",RArm,LArm,Chest, Cluster.ImprovementType.Ability));
  Clusters.Add(new Cluster("Swimming",Leg,RArm,LArm, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Time & Space",Head,RHand,Eye, Cluster.ImprovementType.Nanos));
  Clusters.Add(new Cluster("Trap Disarm",RHand,LHand,Head, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Treatment",Head,Eye,RHand, Cluster.ImprovementType.CombatHeal));
  Clusters.Add(new Cluster("Tutoring",Eye,Ear,Head, Cluster.ImprovementType.TradeRepair));
  Clusters.Add(new Cluster("Vehicle Air",Eye,Ear,Head, Cluster.ImprovementType.Explore));
  Clusters.Add(new Cluster("Vehicle Ground",Head,Eye,Ear, Cluster.ImprovementType.Explore));
  Clusters.Add(new Cluster("Vehicle Water",Head,Eye,Ear, Cluster.ImprovementType.Explore));
  Clusters.Add(new Cluster("Weaponsmithing",RHand,Head,Eye, Cluster.ImprovementType.TradeRepair));
}

  private void OnCBOKey(object sender, KeyEventArgs e)
  {
   ComboBox cbo=(ComboBox)sender;
   if (e.KeyCode==Keys.Escape) cbo.SelectedIndex=-1;
  }

  private void OnCBODrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   RectangleF rct;
   ComboBox cbo=(ComboBox)sender;
   Brush back=new SolidBrush(cbo.BackColor);   
   SizeF sz;
   Cluster c=null;
   String tL="";
   String tR="";

   if (e.Index>=0)
    {
     c=(Cluster)cbo.Items[e.Index];
     tL=c.ClusterName;
     tR=c.Improvement();
    }

   e.DrawBackground();
   e.Graphics.DrawString(tL, cbo.Font, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
   if (e.Index>=0 && (e.State & DrawItemState.ComboBoxEdit)==0)
    {
     sz=e.Graphics.MeasureString(c.MaxImprovement,cbo.Font);
     rct=new RectangleF(e.Bounds.Width-(sz.Width+2),e.Bounds.Y,sz.Width,e.Bounds.Height);
     e.Graphics.DrawString(tR, cbo.Font, System.Drawing.Brushes.Black, rct);
    }
   back.Dispose();
  }
  
  };

}
