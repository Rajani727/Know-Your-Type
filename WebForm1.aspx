<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="KnowYourType.WebForm1" %>


<!DOCTYPE html>
<html>
<head runat="server">
    <title>What's Your Type?</title>

    <link href="StyleSheet1.css" rel="stylesheet" />
</head>

<body>


<form id="form1" runat="server">

    <div class="hero">
        <div style="font-size:30px;">✦ ✧ ✦</div>

        <h1>What's Your Type?</h1>

        <p>
            15 questions • 1 personality type • 1 aesthetic ✨
        </p>
    </div>

    <div class="container">

        <% if (!ShowResult) { %>

        <div class="card intro">
            <h2>🪞 Discover Your Vibe</h2>

            <p>
                Answer honestly. There are no right or wrong answers.
            </p>
        </div>

        <asp:Label ID="lblError"
            runat="server"
            CssClass="error">
        </asp:Label>

        <div class="card">

            <!-- QUESTION 1 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">1</span>
                    After a long week, what sounds best?
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q1" value="E" id="q1a">
                        <label for="q1a">
                            🎉 Go out and meet people
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q1" value="I" id="q1b">
                        <label for="q1b">
                            🛋️ Stay home and recharge
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 2 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">2</span>
                    At a party, you usually...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q2" value="E" id="q2a">
                        <label for="q2a">
                            🗣️ Talk to new people
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q2" value="I" id="q2b">
                        <label for="q2b">
                            👀 Stay with people I know
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 3 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">3</span>
                    Your ideal day is...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q3" value="E" id="q3a">
                        <label for="q3a">
                            ☀️ Full of plans and people
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q3" value="I" id="q3b">
                        <label for="q3b">
                            🌙 Quiet with alone time
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 4 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">4</span>
                    When you meet someone new...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q4" value="E" id="q4a">
                        <label for="q4a">
                            💬 I easily start talking
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q4" value="I" id="q4b">
                        <label for="q4b">
                            🌱 I take time to open up
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 5 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">5</span>
                    When learning something new...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q5" value="S" id="q5a">
                        <label for="q5a">
                            📌 I prefer facts and examples
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q5" value="N" id="q5b">
                        <label for="q5b">
                            💭 I prefer ideas and possibilities
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 6 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">6</span>
                    Which sounds more like you?
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q6" value="S" id="q6a">
                        <label for="q6a">
                            🔎 I notice small details
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q6" value="N" id="q6b">
                        <label for="q6b">
                            🔮 I notice possibilities
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 7 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">7</span>
                    When someone tells you a story...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q7" value="S" id="q7a">
                        <label for="q7a">
                            🧾 I focus on what happened
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q7" value="N" id="q7b">
                        <label for="q7b">
                            🌌 I think about what it means
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 8 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">8</span>
                    You trust...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q8" value="S" id="q8a">
                        <label for="q8a">
                            🧱 Experience and facts
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q8" value="N" id="q8b">
                        <label for="q8b">
                            ✨ Intuition and gut feeling
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 9 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">9</span>
                    During an argument...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q9" value="T" id="q9a">
                        <label for="q9a">
                            ⚖️ I focus on logic
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q9" value="F" id="q9b">
                        <label for="q9b">
                            💗 I focus on feelings
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 10 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">10</span>
                    A friend needs advice...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q10" value="T" id="q10a">
                        <label for="q10a">
                            🧠 Give a practical solution
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q10" value="F" id="q10b">
                        <label for="q10b">
                            🤍 Listen and support them
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 11 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">11</span>
                    What matters more?
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q11" value="T" id="q11a">
                        <label for="q11a">
                            📊 What makes sense
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q11" value="F" id="q11b">
                        <label for="q11b">
                            🫶 What feels right
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 12 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">12</span>
                    Your desk is usually...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q12" value="J" id="q12a">
                        <label for="q12a">
                            📋 Organised
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q12" value="P" id="q12b">
                        <label for="q12b">
                            🎨 A little chaotic
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 13 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">13</span>
                    When you have a deadline...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q13" value="J" id="q13a">
                        <label for="q13a">
                            ✅ Finish early
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q13" value="P" id="q13b">
                        <label for="q13b">
                            🔥 Work under pressure
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 14 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">14</span>
                    Your holiday plan is...
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q14" value="J" id="q14a">
                        <label for="q14a">
                            🗓️ Planned beforehand
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q14" value="P" id="q14b">
                        <label for="q14b">
                            🧳 Decide when I arrive
                        </label>
                    </div>

                </div>

            </div>


            <!-- QUESTION 15 -->

            <div class="question">

                <div class="question-title">
                    <span class="number">15</span>
                    Which feels more like you?
                </div>

                <div class="options">

                    <div class="option">
                        <input type="radio" name="q15" value="N" id="q15a">
                        <label for="q15a">
                            🌠 I imagine how things could be
                        </label>
                    </div>

                    <div class="option">
                        <input type="radio" name="q15" value="S" id="q15b">
                        <label for="q15b">
                            🌻 I enjoy what is happening now
                        </label>
                    </div>

                </div>

            </div>


            <div class="button-area">

                <asp:Button
                    ID="btnReveal"
                    runat="server"
                    Text="✨ Reveal My Type"
                    CssClass="btn"
                    OnClick="btnReveal_Click" />

            </div>

        </div>

        <% } else { %>


        <!-- RESULT -->

        <div class="card result">

            <div class="result-header">

                <div class="small-title">
                    Your personality type
                </div>

                <div class="mbti">
                    <%= PersonalityType %>
                </div>

                <div class="personality-name">
                    <%= PersonalityName %>
                </div>

                <p class="description">
                    <%= PersonalityDescription %>
                </p>

            </div>


            <div class="result-body">

                <div class="small-title">
                    And your aesthetic is
                </div>

                <h2 class="aesthetic-name">
                    <%= AestheticName %>
                </h2>

                <div class="image-grid">

    <% foreach (string image in AestheticImages) { %>

        <div class="image-box">
            <img src="<%= image %>" alt="Your aesthetic" />
        </div>

    <% } %>

</div>

                <div class="traits">

                    <% foreach (string trait in Traits) { %>

                        <span class="trait">
                            <%= trait %>
                        </span>

                    <% } %>

                </div>


                <div class="small-title">
                    Your colour palette
                </div>

                <div class="palette">

                    <% foreach (string color in Palette) { %>

                        <span
                            class="color"
                            style="background:<%= color %>;">
                        </span>

                    <% } %>

                </div>


                <asp:Button
                    ID="btnAgain"
                    runat="server"
                    Text="↻ Take Quiz Again"
                    CssClass="btn"
                    OnClick="btnAgain_Click" />

            </div>

        </div>

        <% } %>

    </div>

</form>

</body>
</html>
