<template>
    <div class="Bottom">
        <div class="fTop">
            <div class="tleft">
            <img src="../assets/img/logo-footer.png" alt="">
                <p>Duis aute irure dolor in reprehen <br> derit in voluptate velit esse cillum <br> dolore eu fugiat nulla pariatur.</p>
                <i class="fa-brands fa-facebook-f"></i>
                <i class="fa-brands fa-twitter"></i>
                <i class="fa-brands fa-youtube"></i>
            </div>
            <div class="tmid-left">
                <h3>Contact us</h3>
                <p>Email: <span style="color: crimson;"> info@example.com</span></p>
                <p>Tel:<span> +1 234 567 890</span></p>
                <p>Address:<span> 123 Fifth Avenue, New York,</span></p>
                <p><span> NY 10160</span></p>
            </div>
            <div class="tmid-right">
                <h3>Useful links</h3>
                <RouterLink class="Routt" :to="{name:'shopPage'}">Shop All</RouterLink>
                <RouterLink class="Routt" :to="{name:'scooterPage'}">Electric Scooters</RouterLink>
                <RouterLink class="Routt" :to="{name:'accessoPage'}">Accessories</RouterLink>
                <RouterLink class="Routt" :to="{name:'aboutPage'}">About</RouterLink>
                <RouterLink class="Routt" :to="{name:'contactPage'}">Contact</RouterLink>
            </div>
            <div class="tright">
                <h3>Sign up for special <br> offers</h3>
                <input type="text" placeholder="Email Address">
                <button>SUBSCRIBE</button>
            </div>
        </div>
        <div class="fBottom">
            <div class="fBottom-left">
                <p>Copyright © 2024 Electric Scooter | Powered by Electric Scooter</p>
            </div>
            <div class="fBottom-right">
                <img src="../assets/img/payment-icons.png" alt="">
            </div>
        </div>
    </div>
</template>
<style scoped>
    .Bottom{
        width: 100%;
        height: 70vh;
        background-color: #e9e9e9;
    }
    .fTop{
        width: 100%;
        height: 68vh;
        display: flex;
        align-items:center;
        justify-content: space-evenly;
        border-bottom: 0.5px solid gray;
    }
    .tleft{
        height: 300px;
    }
    .tleft p{
        color: gray;
        line-height: 1.7;
    }
    .tleft img{
        height: 15%;
    }
    .tleft i{
        text-align: center;
        font-size: 16px;
        padding: 7px;
        width: 30px;
        height: 30px;
        color: white;
        margin: 50px 10px;
        background-color: black;
    }
    .tleft i:hover{
        background-color: crimson;
    }
    .tmid-left{
        height: 300px;
    }
    .tmid-left h3{
        font-size: 22px;
        margin-bottom: 30px;
    }
    .tmid-left p{
        line-height: 2;
        font-size: 14px;
        color: gray;
    }
    .tmid-right{
        height: 300px;
        display: flex;
        flex-direction: column;
    }
    .tmid-right h3{
        font-size: 22px;
        margin-bottom: 30px;
    }
    .Routt{
        line-height: 2;
        color: crimson;
    }
    .Routt:hover{
        color: black;
    }
    .tright{
        height: 300px;
        display: flex;
        flex-direction: column;
    }
    .tright h3{
        font-size: 22px;
        margin-bottom: 20px;
    }
    .tright input{
        width: 240px;
        padding-left:10px ;
        height: 40px;
        margin: 20px 0;
    }
    .tright button{
        cursor: pointer;
        width: 140px;
        height: 50px;
        font-size: 14px;
        border-radius: 10px;
        color: white;
        letter-spacing: 2px;
        background-color: crimson;
        border: none;
    }
    .tright button:hover{
        background-color: rgb(149, 0, 30);
    }
    .fBottom{
        width: 95%;
        margin: auto;
        height: 13vh;
        padding: 0 30px;
        display: flex;
        justify-content: space-between;
    }
    .fBottom-left{
        width: 50%;
        display: flex;
        align-items: center;
        justify-content: start;
    }
    .fBottom-left p{
        font-size: 14px;
        color: gray;
    }
    .fBottom-right{
        width: 50%;
        display: flex;
        align-items: center;
        justify-content: end;
    }
    .fBottom-right img{
        width: 50%;
    }
</style>