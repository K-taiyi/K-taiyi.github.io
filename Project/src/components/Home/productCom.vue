<template>
    <div class="Product">
        <div class="pBox">
            <div class="phide">
                <RouterLink to=""><i class="fa-solid fa-briefcase"></i></RouterLink>
                <RouterLink to=""><i class="fa-solid fa-eye"></i></RouterLink>
            </div>
            <div class="pImg">
                <img src="../../assets/img/scooter-02.jpg" alt="">
            </div>
            <div class="pTxt">
                <i>Libero X350</i>
                <p><span>$875.00 </span> $799.00</p>
            </div>
        </div>
        <div class="pBox">
            <div class="phide">
                <RouterLink to="" id="addTocart"><i class="fa-solid fa-briefcase"></i></RouterLink>
                <RouterLink to=""><i class="fa-solid fa-eye"></i></RouterLink>
            </div>
            <div class="pImg">
                <img src="../../assets/img/scooter-03.jpg" alt="">
            </div>
            <div class="pTxt">
                <i>Practico S2 Exclusive</i>
                <p><span> $750.00 </span> $600.00</p>
            </div>
        </div>
        <div class="pBox">
            <div class="phide">
                <RouterLink to=""><i class="fa-solid fa-briefcase"></i></RouterLink>
                <RouterLink to=""><i class="fa-solid fa-eye"></i></RouterLink>
            </div>
            <div class="pImg">
                <img src="../../assets/img/lock-02.jpg" alt="">
            </div>
            <div class="pTxt">
                <i>U-Lock Force MAX</i>
                <p><span>$90.00 </span> $75.00</p>
            </div>
        </div>
        <div class="pBox">
            <div class="phide">
                <RouterLink to=""><i class="fa-solid fa-briefcase"></i></RouterLink>
                <RouterLink to=""><i class="fa-solid fa-eye"></i></RouterLink>
            </div>
            <div class="pImg">
                <img src="../../assets/img/lock-01.jpg" alt="">
            </div>
            <div class="pTxt">
                <i>Unbeatable Lock 100</i>
                <p><span>$80.00 </span> $69.00</p>
            </div>
        </div>
    </div>
</template>
<style scoped>
    .Product{
        width: 100%;
        display: flex;
        margin-top: 100px;
        justify-content: space-evenly;
    }
    .pBox{
        width: 23%;
        height: 500px;
        position: relative;
        overflow: hidden;
    }
    .phide{
        width: 20%;
        position: absolute;
        right: 0;
        height: 25%;
        display: flex;
        flex-direction: column;
        visibility: hidden;
        align-items: center;
        justify-content: space-evenly;
        transition: 0.1s;
    }
    .phide i{
        padding: 5px;
        font-size: 16px;
        color: black;
        border-radius: 20px;
        background-color: gainsboro;
    }
    .pBox:hover .phide{
        visibility: visible;
        transition: 0.5s;
    }
    .pImg{
        width: 100%;
        height: 80%;
    }
    .pImg img{
        height: 100%;
        width: 100%;
    }
    .pTxt{
        width: 100%;
        height: 20%;
        padding: 20px 10px;
        line-height: 1.8;
    }
    .pTxt p{
        font-size: 16px;
    }
    .pTxt span{
        font-size: 14px;
        color: rgb(183, 182, 182);
    }
</style>