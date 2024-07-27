<template>
    <div class="smallBackground">
        <div class="Bsmall-box">
            <h1>Buy one  <span>and</span> get one free</h1>
            <img src="../../assets/img/moto.png" alt="">
        </div>
    </div>
</template>

<style scoped>
    .smallBackground{
        width: 100%;
        height: 85vh;
        background: url(../../assets/img/back.webp);
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: contain;
        place-content: center;
        position: relative;
    }
    .Bsmall-box{
        width: 500px;
        height: 500px;
        background-color: whitesmoke;
        text-align: center;
        position: absolute;
        border-radius:5px;
        right: 58px;
        bottom: 55px; 
    }
    .Bsmall-box img{
        width: 80%;
    }
    .Bsmall-box h1{
        font-size: 45px;
        font-family: "Playwrite IT Moderna", cursive;
    }
    .Bsmall-box span{
        font-family: "Playwrite IT Moderna", cursive;
        color: crimson;
    }
</style>