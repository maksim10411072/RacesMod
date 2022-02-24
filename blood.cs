using UnityEngine;

namespace Mod
{
    public class aCream : SyringeBehaviour
    {
        public override string GetLiquidID() => Cream.ID;
        public class Cream : Liquid
        {
            public const string ID = "CREAM";

            public Cream()
            {
                Color = new Color(1f, 0.99f, 0.91f, 1);
            }
            public override void OnEnterLimb(LimbBehaviour limb)
            {
            
            }
            public override void OnUpdate(BloodContainer container)
            {

            }
            public override void OnEnterContainer(BloodContainer container)
            {

            }
            public override void OnExitContainer(BloodContainer container)
            {

            }
        }
    }
    public class aChocolate : SyringeBehaviour
    {
        public override string GetLiquidID() => Chocolate.ID;
        public class Chocolate : Liquid
        {
            public const string ID = "CHOCOLATE";

            public Chocolate()
            {
                Color = new Color(0.23f, 0.11f, 0.12f, 1);
            }
            public override void OnEnterLimb(LimbBehaviour limb)
            {

            }
            public override void OnUpdate(BloodContainer container)
            {

            }
            public override void OnEnterContainer(BloodContainer container)
            {

            }
            public override void OnExitContainer(BloodContainer container)
            {

            }
        }
    }
    public class aPotatoJuice : SyringeBehaviour
    {
        public override string GetLiquidID() => PotatoJuice.ID;
        public class PotatoJuice : Liquid
        {
            public const string ID = "POTATOJUICE";

            public PotatoJuice()
            {
                Color = new Color(0.83f, 0.57f, 0.18f, 1);
            }
            public override void OnEnterLimb(LimbBehaviour limb)
            {

            }
            public override void OnUpdate(BloodContainer container)
            {

            }
            public override void OnEnterContainer(BloodContainer container)
            {

            }
            public override void OnExitContainer(BloodContainer container)
            {

            }
        }
    }
    public class aAppleJuice : SyringeBehaviour
    {
        public override string GetLiquidID() => AppleJuice.ID;
        public class AppleJuice : Liquid
        {
            public const string ID = "APPLEJUICE";

            public AppleJuice()
            {
                Color = new Color(0.83f, 0.57f, 0.18f, 1);
            }
            public override void OnEnterLimb(LimbBehaviour limb)
            {

            }
            public override void OnUpdate(BloodContainer container)
            {

            }
            public override void OnEnterContainer(BloodContainer container)
            {

            }
            public override void OnExitContainer(BloodContainer container)
            {

            }
        }
    }
    public class aCucumberJuice : SyringeBehaviour
    {
        public override string GetLiquidID() => CucumberJuice.ID;
        public class CucumberJuice : Liquid
        {
            public const string ID = "CUCUMBERJUICE";

            public CucumberJuice()
            {
                Color = new Color(0.37f, 0.75f, 0.11f, 1);
            }
            public override void OnEnterLimb(LimbBehaviour limb)
            {

            }
            public override void OnUpdate(BloodContainer container)
            {

            }
            public override void OnEnterContainer(BloodContainer container)
            {

            }
            public override void OnExitContainer(BloodContainer container)
            {

            }
        }
    }
}