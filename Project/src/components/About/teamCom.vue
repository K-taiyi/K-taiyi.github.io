<template>
    <div class="myTeam">
        <div class="teamIntro"><h1>CO-founder</h1></div>
        <div class="TeamBox">
            <div class="teamBox">
                <img src="../../assets/img/me.jpg" alt="">
                <div class="teamTxt">
                    <h2>Co<span>-</span>founder <span>:</span> <br> Taiyi Korm</h2>
                    <p>21 years old from Takeo province.</p>
                </div>
            </div>
            <div class="teamBox">
                <img src="../../assets/img/heng.jpg" alt="">
                <div class="teamTxt">
                    <h2>Co<span>-</span>founder <span>:</span> <br> Songheng Kov</h2>
                    <p>20 years old from Banteay Meanchey province.</p>
                </div>
            </div>
            <div class="teamBox">
                <img src="../../assets/img/rak.jpg" alt="">
                <div class="teamTxt">
                    <h2>Co<span>-</span>founder <span>:</span> <br> Linnorak kosal</h2>
                    <p>20 years old from phnom penh.</p>
                </div>
            </div>
            <div class="teamBox">
                <img id="together" src="../../assets/img/together.jpg" alt="">
            </div>
        </div>
    </div>
</template>

<style scoped>
    .myTeam{
        width: 100%;
    }
    .teamIntro{
        width: 100%;
        padding: 20px ;
        color: crimson;
        font-size: 25px;
    }
    .TeamBox{
        width: 90%;
        margin: auto;
        display: flex;
        align-items: center;
        justify-content: space-evenly;
        flex-wrap: wrap;
    }
    .teamBox{
        width: 550px;
        height: 400px;
        background-color:ghostwhite;
        margin-top: 20px;
        display: flex;
    }
    .teamBox img{
        width: 50%;
        height: 70%;
    }
    .teamTxt span{
        color: crimson;
    }
    .teamTxt{
        padding: 20px;
    }
    .teamTxt h2{
        margin-bottom: 20px;
    }
    #together{
        width: 100%;
        height: 100%;
    }
</style>