<template>
    <div class="hBenner">
        <div class="ben-left">
            <div class="t-top">
                <h1>Libero X250</h1>
                <h2>250 Watt Electric Scooter</h2>
            </div>
            <div class="t-mid">
                <h3>Informations:</h3>
                <div class="tmidBox">
                    <div class="tmid-child">
                        <span>30 <br> Km</span>
                        <p>BATTERY</p>
                    </div>
                    <div class="tmid-child">
                        <span>13,5<br> Kg</span>
                        <p>WEIGHT</p>
                    </div>
                    <div class="tmid-child">
                        <span>25 <br> Km/h</span>
                        <p>SPEED</p>
                    </div>
                </div>
            </div>
            <div class="tbottomBox">
                <span>$750.00</span>
            </div>
        </div>
        <div class="ben-mid">
            <img src="../../assets/img/scooter-01.png" alt="">
        </div>
        <div class="ben-right">
            <div class="t-text">
                <h2>Description</h2>
                <p>The Fully Loaded Libero x250 is a High Performance, Extremely Durable, High Speed, Lightweight Electric Scooter with a Huge Battery</p>
            </div>
        </div>
    </div>
</template>
<style scope>
    *{
        font-family: "Dosis", sans-serif;
    }
    .hBenner{
        width:90%;
        height: 100vh;
        margin: auto;
        display: flex;
        align-items: self-end;
        justify-content: center;
    }

    .ben-left{
        width: 30%;
        height: 100%;
        display: flex;
        flex-direction: column;
        justify-content:space-evenly;
    }
    .t-top h1{
        font-size: 60px;
        color: black;
    }
    .t-top h2{
        font-size: 26px;
        color: gray;
        margin-top: 15px;
    }
   
    .t-mid h3{
        font-size: 20px;
    }
    .tmidBox{
        width: 100%;
        display: flex;
        margin-top: 10px;
    }
    .tmid-child{ 
        padding: 10px 15px;
        border: 1px solid black;
        border-radius: 10px;
        text-align: center;
        margin: 0 5px;
    }
    .tmid-child span{
        color: black;
        font-size: 25px;
        font-weight: 900;
    }
    .tmid-child p{
        font-size: 12px;
        color: gray;
    }
    .tbottomBox{
        width: 100%;
    }

    .ben-mid{
        width: 45%;
        height: 70%;
        display: flex;
        justify-content: center;
    }
    .ben-mid img{
        height: 100%;
    }

    .ben-right{
        width: 20%;
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
    }
    .t-text p{
        line-height: 1.6;
        font-size: 16px;
        color: gray;
    }
    .t-text h2{
        margin-bottom: 10px;
    }
</style>