using System.Collections;
using System;
using UnityEngine;
namespace Mod
{
    public class Mod : MonoBehaviour
    {

        public static void Main()
        {
            ModAPI.RegisterLiquid(aCream.Cream.ID, new aCream.Cream());
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Cake -Races",
                DescriptionOverride = "Cake!",
                CategoryOverride = ModAPI.FindCategory("Entities"),
                ThumbnailOverride = ModAPI.LoadSprite("CakeThumb.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("Cake.png");
                    var flesh = ModAPI.LoadTexture("CakeFlesh.png");
                    var bone = ModAPI.LoadTexture("CakeSkeleton.png");
                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.SetBodyTextures(skin, flesh, bone, 1);
                    person.SetBruiseColor(141, 67, 36); //main bruise colour. purple-ish by default
                    person.SetSecondBruiseColor(141, 67, 36); //second bruise colour. red by default
                    person.SetThirdBruiseColor(141, 67, 36);
                    foreach (var body in person.Limbs)
                    {
                        body.RegenerationSpeed = 20f;
                        body.DiscomfortingHeatTemperature = 10f;
                        body.FreezingTemperature = -999999f;
                        body.BodyTemperature = 0f;
                        body.BloodLiquidType = "CREAM";
                        body.CirculationBehaviour.ClearLiquid();
                        body.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("CREAM"), 0.5f);
                    }
                }
            });
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Astro -Races",
                DescriptionOverride = "Astro!",
                CategoryOverride = ModAPI.FindCategory("Entities"),
                ThumbnailOverride = ModAPI.LoadSprite("AstroThumb.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("Astro.png");
                    var flesh = ModAPI.LoadTexture("AstroFlesh.png");
                    var bone = ModAPI.LoadTexture("AstroSkeleton.png");
                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.SetBodyTextures(skin, flesh, bone, 1);
                    person.SetBruiseColor(0, 0, 0); //main bruise colour. purple-ish by default
                    person.SetSecondBruiseColor(0, 0, 0); //second bruise colour. red by default
                    person.SetThirdBruiseColor(0, 0, 0);
                    foreach (var body in person.Limbs)
                    {
                        body.RegenerationSpeed = 200000000000000000000000000000f;
                        body.DiscomfortingHeatTemperature = 999999f;
                        body.FreezingTemperature = -999999f;
                        body.BodyTemperature = 0f;
                        body.Vitality = 2f;
                        body.IsLethalToBreak = false;
                        body.CirculationBehaviour.BloodFlow *= 0f;
                        body.BloodLiquidType = "ASTRO SERUM";
                        body.CirculationBehaviour.ClearLiquid();
                        body.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("ASTRO SERUM"), 4f);
                    };
                }
            });
            ModAPI.RegisterLiquid(aChocolate.Chocolate.ID, new aChocolate.Chocolate());
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Cookie -Races",
                DescriptionOverride = "Cookie!",
                CategoryOverride = ModAPI.FindCategory("Entities"),
                ThumbnailOverride = ModAPI.LoadSprite("CookieThumb.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("Cookie.png");
                    var flesh = ModAPI.LoadTexture("CookieFlesh.png");
                    var bone = ModAPI.LoadTexture("CookieSkeleton.png");
                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.SetBodyTextures(skin, flesh, bone, 1);
                    person.SetBruiseColor(84, 36, 20); //main bruise colour. purple-ish by default
                    person.SetSecondBruiseColor(84, 36, 20); //second bruise colour. red by default
                    person.SetThirdBruiseColor(84, 36, 20);
                    foreach (var body in person.Limbs)
                    {
                        body.RegenerationSpeed = 0f;
                        body.DiscomfortingHeatTemperature = 30f;
                        body.FreezingTemperature = -30f;
                        body.BodyTemperature = 0f;
                        body.Vitality *= 0.5f;
                        body.BloodLiquidType = "CHOCOLATE";
                        body.CirculationBehaviour.ClearLiquid();
                        body.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("CHOCOLATE"), 0.5f);
                    };
                }
            });
            ModAPI.RegisterLiquid(aPotatoJuice.PotatoJuice.ID, new aPotatoJuice.PotatoJuice());
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Potato -Races",
                DescriptionOverride = "Potato!",
                CategoryOverride = ModAPI.FindCategory("Entities"),
                ThumbnailOverride = ModAPI.LoadSprite("PotatoThumb.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("Potato.png");
                    var flesh = ModAPI.LoadTexture("PotatoFlesh.png");
                    var bone = ModAPI.LoadTexture("PotatoSkeleton.png");
                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.SetBodyTextures(skin, flesh, bone, 1);
                    person.SetBruiseColor(84, 36, 20); //main bruise colour. purple-ish by default
                    person.SetSecondBruiseColor(84, 36, 20); //second bruise colour. red by default
                    person.SetThirdBruiseColor(84, 36, 20);
                    foreach (var body in person.Limbs)
                    {
                        body.RegenerationSpeed = 100f;
                        body.DiscomfortingHeatTemperature = 50f;
                        body.FreezingTemperature = -40f;
                        body.BodyTemperature = 0f;
                        body.Vitality *= 1.5f;
                        body.BaseStrength = 10f;
                        body.BloodLiquidType = "POTATOJUICE";
                        body.CirculationBehaviour.ClearLiquid();
                        body.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("POTATOJUICE"), 1f);
                    };
                }
            });
            ModAPI.RegisterLiquid(aAppleJuice.AppleJuice.ID, new aAppleJuice.AppleJuice());
            ModAPI.RegisterLiquid(aCucumberJuice.CucumberJuice.ID, new aCucumberJuice.CucumberJuice());
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Cucumber -Races",
                DescriptionOverride = "Cucumber!",
                CategoryOverride = ModAPI.FindCategory("Entities"),
                ThumbnailOverride = ModAPI.LoadSprite("Cucumber.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("Cucumber.png");
                    var flesh = ModAPI.LoadTexture("CucumberFlesh.png");
                    var bone = ModAPI.LoadTexture("CucumberSkeleton.png");
                    var person = Instance.GetComponent<PersonBehaviour>();
                    //var head = Instance.transform.Find("Head");
                    person.SetBodyTextures(skin, flesh, bone, 1);
                    person.SetBruiseColor(84, 36, 20); //main bruise colour. purple-ish by default
                    person.SetSecondBruiseColor(84, 36, 20); //second bruise colour. red by default
                    person.SetThirdBruiseColor(84, 36, 20);
                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Cucumber!");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, (6.5f * ModAPI.PixelSize));
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("newCucumberHead.png");
                    childSprite.sortingLayerName = "Top";
                    //head.gameObject.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("newCucumberHead.png");
                    //head.gameObject.GetComponent<SpriteRenderer>().material.SetTexture(ShaderProperties.Get("_FleshTex"), ModAPI.LoadTexture("newCucumberHeadFlesh.png"));
                    //head.gameObject.GetComponent<SpriteRenderer>().material.SetTexture(ShaderProperties.Get("_BoneTex"), ModAPI.LoadTexture("newCucumberHeadSkeleton.png"));
                    foreach (var body in person.Limbs)
                    {
                        body.RegenerationSpeed = 10f;
                        body.DiscomfortingHeatTemperature = 60f;
                        body.FreezingTemperature = -40f;
                        body.BodyTemperature = 0f;
                        body.Vitality *= 1.2f;
                        body.BloodLiquidType = "CUCUMBERJUICE";
                        body.CirculationBehaviour.ClearLiquid();
                        body.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("CUCUMBERJUICE"), 1f);
                    };
                }
            });
            ModAPI.RegisterLiquid(AstroBlood.AstroSerum.ID, new AstroBlood.AstroSerum());

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Acid Syringe"),
                    NameOverride = "Astroblood",
                    DescriptionOverride = "A F###in Blood from F###in space",
                    CategoryOverride = ModAPI.FindCategory("Biohazard"),
                    ThumbnailOverride = ModAPI.LoadSprite("AstroBloodThumb.png"),
                    AfterSpawn = (Instance) =>
                    {
                        UnityEngine.Object.Destroy(Instance.GetComponent<SyringeBehaviour>());
                        Instance.GetOrAddComponent<AstroBlood>();
                    }
                }
            );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("1000kg Weight"),
                    NameOverride = "fsgg",
                    DescriptionOverride = "fsgfsgs",
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                   // ThumbnailOverride = ModAPI.LoadSprite("AstroBloodThumb.png"),
                    AfterSpawn = (Instance) =>
                    {
                        ModAPI.Notify(Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass);
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 250000000;
                    }
                }
            );

        }

    }
    public class AstroBlood : SyringeBehaviour
    {
        public override string GetLiquidID() => AstroSerum.ID;

        public class AstroSerum : Liquid
        {
            public const string ID = "ASTRO SERUM";

            public AstroSerum()
            {
                Color = new Color(0.4f, 0f, 0.48f, 1);
            }

            public override void OnEnterLimb(LimbBehaviour limb) { }
            public override void OnUpdate(BloodContainer container) 
            {
                if (container is CirculationBehaviour circ && circ.Limb.SpeciesIdentity != Species.Android)
                {
                    circ.Limb.RegenerationSpeed = 200000000000000000000000000000f;
                    circ.Limb.DiscomfortingHeatTemperature = 999999f;
                    circ.Limb.Vitality = 2f;
                    circ.Limb.CirculationBehaviour.HealBleeding();
                    circ.Limb.LungsPunctured = false;
                    circ.Limb.HealBone();
                    if (circ.Limb.RoughClassification == LimbBehaviour.BodyPart.Head)
                    {
                        circ.Limb.Person.Consciousness = 1f;
                        circ.Limb.Person.ShockLevel = 0f;
                        circ.Limb.Person.PainLevel = 0f;
                        circ.Limb.Person.OxygenLevel = 1f;
                    }
                }
            }
            public override void OnEnterContainer(BloodContainer container) { }
            public override void OnExitContainer(BloodContainer container) { }
        }
    }
}