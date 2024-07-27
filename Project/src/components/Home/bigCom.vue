<template>
    <div class="Background">
        <div class="bgImg">
            <img src="../../assets/img/scooter-04.png" alt="">
            <u>CITY</u>
            <h3>Electric Scooter Z400</h3>
            <span>$650</span>
        </div>
    </div>
</template>

<style scoped>
    .Background{
        width: 100%;
        height: 103vh;
        background: url(../../assets/img/background.webp);
        background-repeat: no-repeat;
        background-position:right;
        background-size: cover;
        background-attachment: fixed;
        position: relative;
    }
    .bgImg{
        width: 500px;
        height: 100vh;
        background-color: #F4FAFC;
        position: absolute;
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
        bottom: -100px;
        left: 50px;
        line-height: 1.5;
        box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    }
    .bgImg img{
        width: 80%;
    }
    .bgImg h3{
        letter-spacing: 1px;
    }
    .bgImg span{
        color: crimson;
    }
</style>