<template>
    <div class="cLink">
        <div class="cLink-top">
            <h1>Useful Links</h1>
        </div>
        <div class="cLink-box">
            <div class="uBox">
                <i class="fa-solid fa-handshake"></i>
                <h2>Partnerships</h2>
                <p>Interested in a partnership with us?</p>
                <RouterLink class="uLink" to="">APPLY HERE</RouterLink>
            </div>
            <div class="uBox">
                <i class="fa-solid fa-question"></i>
                <h2> FAQ</h2>
                <p>Most questions can be answered here.</p>
                <RouterLink class="uLink" to="">GO TO FQA</RouterLink>
            </div>
            <div class="uBox">
                <i class="fa-solid fa-location-dot"></i>
                <h2>Store Locations</h2>
                <p>Find your nearest Electric Scooter store.</p>
                <RouterLink class="uLink" to="">FIND STORE</RouterLink>
            </div>
        </div>
    </div>
</template>
<style scoped>
    .cLink{
        width: 100%;
        height: 80vh;
        display: flex;
        flex-direction: column;
        background: linear-gradient(to bottom, aquamarine ,teal);
        justify-content: space-between;
    }
    .cLink-top{
        font-size: 25px;
        width: 100%;
        text-align: center;
        padding: 20px 0;
    }
    .cLink-box{
        width: 90%;
        margin: auto;
        display: flex;
        align-items: center;
        justify-content: space-evenly;
    }
    .uBox{
        text-align: center;
        display: flex;
        flex-direction: column;
        align-items: center;
        border-top: 1px solid black;
        border-bottom: 1px solid black;
        padding: 30px;
        color: black;
        justify-content: space-evenly;
    }
    .uBox i{
        width: 40px;
        font-size: 20px;
        display: flex;
        margin-bottom: 20px;
        align-items: center;
        justify-content: center;
        height: 40px;
        color: crimson;
        border-radius: 100%;
        background-color: gainsboro;
    }
    .uBox:hover{
        color: white;
        background-color: rgb(29, 27, 27);
    }
    .uBox:hover i{
        box-shadow: rgb(107, 41, 41) 0px 5px 15px;
        color: white;
        background-color: crimson;
    }
    .uLink{
        padding: 10px 20px;
        margin-top: 20px;
        background-color: crimson;
        color: white;
        letter-spacing: 1px;
    }
</style>