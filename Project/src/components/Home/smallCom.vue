<template>
    <div class="smallBackground">
        <div class="Bsmall-box">
            <img src="../../assets/img//kid.webp" alt="">
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
        text-align: center;
        position: absolute;
        border-radius:5px;
        right: 58px;
        bottom: 55px; 
    }
    .Bsmall-box img{
        width: 80%;
    }
    .Bsmall-box span{
        font-family: "Playwrite IT Moderna", cursive;
        color: crimson;
    }
</style>