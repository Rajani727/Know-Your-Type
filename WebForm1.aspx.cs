using System;
using System.Collections.Generic;
using System.Web.UI;
using static System.Net.WebRequestMethods;

namespace KnowYourType
{
    public partial class WebForm1 : Page
    {
        protected bool ShowResult = false;

        protected string PersonalityType = "";
        protected string PersonalityName = "";
        protected string PersonalityDescription = "";

        protected string AestheticName = "";

        protected List<string> AestheticImages =
            new List<string>();

        protected List<string> Traits =
            new List<string>();

        protected List<string> Palette =
            new List<string>();


        // =========================================================
        // 4 IMAGES FOR EACH AESTHETIC
        // =========================================================

        Dictionary<string, List<string>> aestheticImages =
            new Dictionary<string, List<string>>()
        {
            {
                "Dreamy Soft",
                new List<string>
                {
                    "https://i.pinimg.com/736x/6c/0b/15/6c0b15f83aa9871f46714293a69b33e5.jpg",
                    "https://i.pinimg.com/736x/e9/ae/63/e9ae637d02f49a790edc78bc5127f096.jpg",
                    "https://i.pinimg.com/736x/e1/4b/ba/e14bbafe71ad9a7c9a749ee30e601b83.jpg",
                    "https://i.pinimg.com/1200x/2f/de/97/2fde97a4254415ce4cff6aa0c3a1b147.jpg" }
            },

            {
                "Cottagecore",
                new List<string>
                {
                    "https://i.pinimg.com/1200x/34/85/49/34854932ef8343a2b3616e48fa72c30f.jpg",
                    "https://i.pinimg.com/1200x/f9/2c/a7/f92ca7c25cb1574bcf9fa516fe82ff39.jpg",
                    "https://i.pinimg.com/736x/14/fd/08/14fd08d2fcffcab653b48d25ffc84f7b.jpg",
                    "https://i.pinimg.com/736x/97/68/6b/97686bc80ed637ea963d9f2e1bfda07a.jpg"
                }
            },

            {
                "Dark Academia",
                new List<string>
                {
                    "https://i.pinimg.com/736x/5a/96/d6/5a96d675099b183c4c5dad47108b40b8.jpg",
                    "https://i.pinimg.com/1200x/3b/75/30/3b7530fa72bb119c0e15c423516ebb1e.jpg",
                    "https://i.pinimg.com/736x/40/74/6c/40746cb186aa3bb3be128fe5af24761c.jpg",
                    "https://i.pinimg.com/736x/01/9b/f9/019bf9913eebf27ee244ccf125fc73ec.jpg"  }
            },

            {
                "Y2K Energy",
                new List<string>
                {
                    "https://i.pinimg.com/736x/7b/7a/1c/7b7a1c3b171b314e6d01478eab084c8f.jpg",
                    "https://i.pinimg.com/1200x/bc/3e/a3/bc3ea3c56832c902db8556aa24ff7e1d.jpg",
                    "https://i.pinimg.com/736x/f5/4c/a0/f54ca06e013fdb124b32abb803c6390a.jpg",
                    "https://i.pinimg.com/736x/6d/6f/3a/6d6f3ae8dc46c56691374f3a3e9f7d5c.jpg"
                }
            }
        };


        // =========================================================
        // PAGE LOAD
        // =========================================================

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack &&
                Session["ShowResult"] != null)
            {
                ShowResult =
                    (bool)Session["ShowResult"];

                LoadResult();
            }
        }


        // =========================================================
        // REVEAL BUTTON
        // =========================================================

        protected void btnReveal_Click(object sender, EventArgs e)
        {
            string[] questions =
            {
                "q1", "q2", "q3", "q4",
                "q5", "q6", "q7", "q8",
                "q9", "q10", "q11",
                "q12", "q13", "q14", "q15"
            };


            int E = 0;
            int I = 0;

            int S = 0;
            int N = 0;

            int T = 0;
            int F = 0;

            int J = 0;
            int P = 0;


            foreach (string question in questions)
            {
                string answer =
                    Request.Form[question];


                if (String.IsNullOrEmpty(answer))
                {
                    lblError.Text =
                        "Please answer all 15 questions ✨";

                    return;
                }


                switch (answer)
                {
                    case "E":
                        E++;
                        break;

                    case "I":
                        I++;
                        break;

                    case "S":
                        S++;
                        break;

                    case "N":
                        N++;
                        break;

                    case "T":
                        T++;
                        break;

                    case "F":
                        F++;
                        break;

                    case "J":
                        J++;
                        break;

                    case "P":
                        P++;
                        break;
                }
            }


            // =====================================================
            // CREATE PERSONALITY TYPE
            // =====================================================

            PersonalityType =
                (E >= I ? "E" : "I") +
                (S >= N ? "S" : "N") +
                (T >= F ? "T" : "F") +
                (J >= P ? "J" : "P");


            SetPersonality(PersonalityType);

            SetAesthetic(PersonalityType);


            // =====================================================
            // SAVE RESULT IN SESSION
            // =====================================================

            Session["ShowResult"] = true;

            Session["PersonalityType"] =
                PersonalityType;

            Session["PersonalityName"] =
                PersonalityName;

            Session["PersonalityDescription"] =
                PersonalityDescription;

            Session["AestheticName"] =
                AestheticName;

            Session["AestheticImages"] =
                AestheticImages;

            Session["Traits"] =
                Traits;

            Session["Palette"] =
                Palette;


            ShowResult = true;
        }


        // =========================================================
        // PERSONALITY
        // =========================================================

        private void SetPersonality(string type)
        {
            switch (type)
            {
                case "INFP":
                    PersonalityName = "The Mediator";
                    PersonalityDescription =
                        "You are thoughtful, imaginative and deeply connected to your values. " +
                        "You often see the beauty and meaning in small things, care deeply about people, " +
                        "and enjoy expressing yourself through creativity. You may be quiet at first, " +
                        "but your inner world is full of ideas, emotions and dreams.";
                    break;

                case "INFJ":
                    PersonalityName = "The Advocate";
                    PersonalityDescription =
                        "You are thoughtful, intuitive and guided by a strong sense of purpose. " +
                        "You understand people deeply and often notice emotions that others miss. " +
                        "You enjoy meaningful conversations, dream about making a difference, " +
                        "and usually think carefully before taking action.";
                    break;

                case "ENFP":
                    PersonalityName = "The Campaigner";
                    PersonalityDescription =
                        "You are energetic, curious and full of ideas. You love exploring new possibilities, " +
                        "meeting different people and turning ordinary moments into memorable experiences. " +
                        "Your enthusiasm is contagious, and you usually follow what genuinely excites you.";
                    break;

                case "ENFJ":
                    PersonalityName = "The Protagonist";
                    PersonalityDescription =
                        "You are warm, encouraging and naturally focused on people. " +
                        "You enjoy bringing people together, supporting others and helping them become their best. " +
                        "You often take responsibility when needed and care deeply about creating positive connections.";
                    break;

                case "ISFP":
                    PersonalityName = "The Adventurer";
                    PersonalityDescription =
                        "You are creative, observant and quietly adventurous. You enjoy experiencing life in your own way " +
                        "and often express yourself through art, style, music or other creative activities. " +
                        "You value freedom, authenticity and living in the moment rather than following unnecessary rules.";
                    break;

                case "ISFJ":
                    PersonalityName = "The Defender";
                    PersonalityDescription =
                        "You are caring, dependable and thoughtful toward the people around you. " +
                        "You notice the little things and often remember details that others forget. " +
                        "You value stability, loyalty and meaningful relationships, and you are usually someone others can rely on.";
                    break;

                case "ESFP":
                    PersonalityName = "The Entertainer";
                    PersonalityDescription =
                        "You are fun-loving, expressive and full of positive energy. " +
                        "You enjoy being around people, trying new experiences and making everyday moments exciting. " +
                        "Your natural spontaneity and playful personality can make you the person who brings life to the room.";
                    break;

                case "ESFJ":
                    PersonalityName = "The Consul";
                    PersonalityDescription =
                        "You are friendly, caring and naturally aware of the people around you. " +
                        "You enjoy creating a comfortable environment and making others feel included. " +
                        "You value friendship, teamwork and traditions, and you often show your care through thoughtful actions.";
                    break;

                case "INTJ":
                    PersonalityName = "The Architect";
                    PersonalityDescription =
                        "You are independent, strategic and always looking for ways to understand how things work. " +
                        "You enjoy solving complex problems, planning ahead and improving ideas. " +
                        "You usually prefer meaningful conversations and purposeful work over unnecessary small talk.";
                    break;

                case "INTP":
                    PersonalityName = "The Logician";
                    PersonalityDescription =
                        "You are curious, analytical and constantly exploring new ideas. " +
                        "You enjoy asking questions, understanding how things work and finding unusual solutions to problems. " +
                        "Your mind is often busy connecting concepts and exploring possibilities that others may overlook.";
                    break;

                case "ENTJ":
                    PersonalityName = "The Commander";
                    PersonalityDescription =
                        "You are confident, organised and naturally focused on achieving your goals. " +
                        "You enjoy taking initiative, solving problems and turning ideas into action. " +
                        "You tend to think about the bigger picture and are comfortable taking the lead when a challenge appears.";
                    break;

                case "ENTP":
                    PersonalityName = "The Debater";
                    PersonalityDescription =
                        "You are quick-thinking, curious and always ready to explore a new idea. " +
                        "You enjoy discussions, challenges and looking at problems from different perspectives. " +
                        "Your playful curiosity often leads you to question the usual way of doing things and discover creative alternatives.";
                    break;

                case "ISTJ":
                    PersonalityName = "The Logistician";
                    PersonalityDescription =
                        "You are reliable, practical and organised. You prefer having a clear plan and knowing what needs to be done. " +
                        "You take responsibilities seriously, pay attention to details and usually prefer solutions that are realistic, " +
                        "efficient and proven to work.";
                    break;

                case "ISTP":
                    PersonalityName = "The Virtuoso";
                    PersonalityDescription =
                        "You are independent, practical and naturally curious about how things work. " +
                        "You prefer learning through experience and enjoy solving problems in your own way. " +
                        "You tend to stay calm when situations change and are often good at finding simple, practical solutions.";
                    break;
                        q
                case "ESTJ":
                    PersonalityName = "The Executive";
                    PersonalityDescription =
                        "You are organised, direct and dependable. You like knowing what needs to be done and prefer turning plans into real results. " +
                        "You naturally take responsibility, value efficiency and often help bring structure and direction to a group.";
                    break;

                default:
                    PersonalityName = "The Entrepreneur";
                    PersonalityDescription =
                        "You are bold, energetic and adaptable, with a natural ability to respond to new situations. " +
                        "You enjoy exciting experiences, taking action and finding opportunities around you. " +
                        "Your confidence and flexibility help you make the most of unexpected moments.";
                    break;
            }
        }


        // =========================================================
        // AESTHETIC
        // =========================================================

        private void SetAesthetic(string type)
        {
            if (
                type == "INFP" ||
                type == "ISFP" ||
                type == "ENFP" ||
                type == "ESFP"
               )
            {
                AestheticName =
                    "Dreamy Soft 🌸";

                AestheticImages =
                    aestheticImages["Dreamy Soft"];

                Traits = new List<string>
                {
                    "🌸 Creative",
                    "🎧 Emotional",
                    "☁️ Dreamy",
                    "🎀 Expressive"
                };

                Palette = new List<string>
                {
                    "#F7CFE3",
                    "#E8D9FF",
                    "#FFF1F7",
                    "#CDB4DB"
                };
            }


            else if (
                type == "INFJ" ||
                type == "ISFJ" ||
                type == "ENFJ" ||
                type == "ESFJ"
                    )
            {
                AestheticName =
                    "Cottagecore 🌿";

                AestheticImages =
                    aestheticImages["Cottagecore"];

                Traits = new List<string>
                {
                    "🌿 Calm",
                    "📖 Cozy",
                    "🌷 Gentle",
                    "☕ Warm"
                };

                Palette = new List<string>
                {
                    "#A8C69F",
                    "#D8C3A5",
                    "#F5E9D3",
                    "#6B7D5C"
                };
            }


            else if (
                type == "INTJ" ||
                type == "INTP" ||
                type == "ENTJ" ||
                type == "ENTP"
                    )
            {
                AestheticName =
                    "Dark Academia 🖤";

                AestheticImages =
                    aestheticImages["Dark Academia"];

                Traits = new List<string>
                {
                    "📚 Curious",
                    "🕯️ Mysterious",
                    "🖋️ Intellectual",
                    "🌧️ Moody"
                };

                Palette = new List<string>
                {
                    "#272333",
                    "#554C5C",
                    "#8D735B",
                    "#D4C2A8"
                };
            }


            else
            {
                AestheticName =
                    "Y2K Energy 💿";

                AestheticImages =
                    aestheticImages["Y2K Energy"];

                Traits = new List<string>
                {
                    "💿 Bold",
                    "🪩 Energetic",
                    "📸 Playful",
                    "⚡ Confident"
                };

                Palette = new List<string>
                {
                    "#8BE9FD",
                    "#FF8AD8",
                    "#C7A7FF",
                    "#FFF27A"
                };
            }
        }


        // =========================================================
        // LOAD RESULT FROM SESSION
        // =========================================================

        private void LoadResult()
        {
            PersonalityType =
                Session["PersonalityType"]
                as string ?? "";

            PersonalityName =
                Session["PersonalityName"]
                as string ?? "";

            PersonalityDescription =
                Session["PersonalityDescription"]
                as string ?? "";

            AestheticName =
                Session["AestheticName"]
                as string ?? "";


            AestheticImages =
                Session["AestheticImages"]
                as List<string>
                ?? new List<string>();


            Traits =
                Session["Traits"]
                as List<string>
                ?? new List<string>();


            Palette =
                Session["Palette"]
                as List<string>
                ?? new List<string>();
        }


        // =========================================================
        // AGAIN BUTTON
        // =========================================================

        protected void btnAgain_Click(
            object sender,
            EventArgs e)
        {
            Session.Clear();

            Response.Redirect(
                Request.RawUrl);
        }
    }
}