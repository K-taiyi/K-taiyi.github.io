<template>
    <div class="Choose">
        <div class="cHead">
            <u>Why choose us</u>
            <div class="cir"></div>
        </div>
        <div class="cBox">
            <div class="cBox-child">
                <i class="fa-solid fa-truck"></i>
                <h2>Fast Delivery</h2>
                <p>Lorem ipsum dolor sit amet, adipiscing elit, sed do eiusmod tempor consectetur incididunt ut labore</p>
            </div>
            <div class="cBox-child">
                <i class="fa-solid fa-location-arrow"></i>
                <h2>Order Tracking</h2>
                <p>Lorem ipsum dolor sit amet, adipiscing elit, sed do eiusmod tempor consectetur incididunt ut labore</p>
            </div>
            <div class="cBox-child">
                <i class="fa-solid fa-lock"></i>
                <h2>Secure Payment</h2>
                <p>Lorem ipsum dolor sit amet, adipiscing elit, sed do eiusmod tempor consectetur incididunt ut labore</p>
            </div>
        </div>
    </div>
</template>

<style scoped>
    .Choose{
        width: 100%;
        height: 110vh;
        place-content: center;
        background-color: white;
    }
    .cHead{
        width: 100%;
        height: 10vh;
        justify-content: center;
        align-items: center;
        display: flex;
      
    }
    .cHead u{
        font-size: 45px;
        border-bottom: 1px solid crimson;
    }
    .cir{
        width: 20px;
        height: 20px;
        border-radius: 100%;
        margin-left: 30px;
        background-color: rgb(41, 116, 255);
        animation: point 0.5s ease-in-out infinite alternate;
    }
    @keyframes point {
        0%{
            transform: scale(1.1);
        }
        100%{
            transform: scale(1.3);
        }
    }
    .cBox{
        width: 100%;
        display: flex;
        justify-content: space-evenly;
    }
    .cBox-child{
        width: 300px;
        height: 400px;
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
    }
    .cBox-child i{
        padding: 10px;
        font-size: 20px;
        color: white;
        background-color: rgb(212, 6, 47);
        border-radius: 100%;
        margin-bottom: 5px;
    }
    .cBox-child i:hover{
        background-color: black;
    }
    .cBox-child p{
        text-align: center;
        line-height: 1.7;
        margin-top: 20px;
        color: rgb(56, 56, 56);
    }
</style>