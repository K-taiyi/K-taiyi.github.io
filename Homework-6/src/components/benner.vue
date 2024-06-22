<template>
    <div class="benne">
        <img src="../assets/city.svg" alt="">
        <div class="topText">
            <h2>The Best City</h2>
            <p>The best drinks and eats in the best city ever.</p>
        </div>
    </div>
</template>

<style scoped>
    .benne{
        width: 100%;
        height: 400px;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: space-evenly;
        background-color:rgb(37, 251, 251);
    }
    .benne img{
        height: 50%;
    }
    .topText{
        text-align: center;
        color: white;
        font-size: 20px;
    }
</style>