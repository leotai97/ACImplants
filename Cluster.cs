using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOImplants
{
  public class Cluster
  {
   public enum ImprovementType {Ability, BodyDef, Melee, MeleeSpec, Ranged, RangedSpec, Nanos, Explore, CombatHeal, TradeRepair, AC, Max, Jobe};
   public String ClusterName       { get; private set; }
   public Implant Shining          { get; private set; }
   public Implant Bright           { get; private set; }
   public Implant Faded            { get; private set; }
   public ImprovementType Category { get; private set; }
   public String MaxImprovement    { get => "Combat&Heal"; }
   public int ID                   { get; private set; }

   private static int NextID=1;

   public Cluster(String n, Implant s, Implant b, Implant f, ImprovementType type)
    {    
     ClusterName=n;
     Shining=s;
     Bright=b;
     Faded=f;
     Category=type;
     ID=NextID++;
    }

    public override string ToString()
    {
     return ClusterName; 
    }

   public String Improvement()
    {
     switch(Category)
      {
       case ImprovementType.Ability:     return "Ability";
       case ImprovementType.BodyDef:     return "Body&Def";
       case ImprovementType.Melee:       return "Melee";
       case ImprovementType.MeleeSpec:   return "MeleeSpec";
       case ImprovementType.Ranged:      return "Ranged";
       case ImprovementType.RangedSpec:  return "RangedSpec"; 
       case ImprovementType.Nanos:       return "Nanos";
       case ImprovementType.Explore:     return "Explore";
       case ImprovementType.CombatHeal:  return "Combat&Heal";
       case ImprovementType.TradeRepair: return "Trade";
       case ImprovementType.AC:          return "AC";
       case ImprovementType.Max:         return "Max";
       case ImprovementType.Jobe:      return "Jobe";
      }
     return "N/A";
    }


  };


 public class Implant
 {
  public enum enumImplant { Head, Eye, Ear, Chest, RArm, RWrist, RHand, LArm, LWrist, LHand, Waist, Leg, Feet };
  
  public String ImplantName { get; private set; }
  public enumImplant ImplantType { get; private set; }
  public List<Cluster> Clusters { get; private set; }
 
  public Implant(enumImplant t, String n)
  {
   ImplantType=t;
   ImplantName=n;
  }

 };
  
}
