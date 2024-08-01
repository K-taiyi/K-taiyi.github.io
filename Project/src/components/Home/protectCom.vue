<template>
    <div class="protect">
        <div class="protectBox">
            <div class="protectBox-text">
                <h1>Shop Electric <br> Scooter Accessories</h1>
                <RouterLink class="pRout" :to="{name:'accessoPage', params: {cat_id: 2}} ">SHOP ACCESSORIES</RouterLink>
            </div>
            <div class="protectBox-pic">
                <img src="../../assets/img/accessories-01.png" alt="">
            </div>
        </div>
    </div>
</template>
<style scoped>
    .protect{
        width: 100%;
        background-color: #F4FAFC;
    }
    .protectBox{
        width: 85%;
        height: 80vh;
        margin: auto;
        display: flex;
    }
    .protectBox-text{
        width: 50%;
        height: 50%;
        margin: auto;
        font-size: 22px;
    }
    .protectBox-text h1{
        margin-bottom: 20px;
    }
    .pRout{
        padding: 10px 20px;
        background-color: #C83535;
        border-radius: 10px;
        font-size: 16px;
        letter-spacing: 1.5px;
        color: white;
    }

    .protectBox-pic{
        width: 50%;
        height: 100%;
        background-color:bisque;
        margin-top: -4rem;
        padding-top: 30px;
    }
    .protectBox-pic img{
        height: 95%;
        width: 100%;
        margin-left: -38px;
    }
</style>