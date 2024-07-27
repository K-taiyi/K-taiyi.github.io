<template>
    <div class="HeaderCom">
        <div class="hMenu">
            <ul class="Dropdown" type="none">
                <li class="dropList"><RouterLink class="dropLink" :to="{name:'shopPage'}">Shop All</RouterLink></li>
                <li class="dropList"><RouterLink class="dropLink" :to="{name:'scooterPage'}">Electric Scooters</RouterLink></li>
                <li class="dropList"><RouterLink class="dropLink" :to="{name:'accessoPage'}">Accessories</RouterLink></li>
                <li class="dropList"><RouterLink class="dropLink" :to="{name:'aboutPage'}">About</RouterLink></li>
                <li class="dropList"><RouterLink class="dropLink" :to="{name:'contactPage'}">Contact</RouterLink></li>
            </ul>
            <div class="hLogo">
                <img src="../assets/img/logo-regular.png" alt="">
            </div>
        </div>
        <div class="hIcon">
            <div>
                <div :style="{ width: sidePanelWidth }" class="sidepanel" id="mySidepanel">
                    <div class="header-panel">
                        <h1 class="card-panel">Shopping Cart</h1>
                        <a href="#" class="closebtn" @click="closeNav">&times;</a>
                    </div>
                    <hr>
                    <p v-if="cartItems.length === 0">No products in the cart.</p>
                    <!-- <div class="total" v-else>
                        <h1>Total</h1>
                    </div> -->
                </div>
            </div>        
            <a href="#" @click="openNav"><i id="openbtn" class="fa-solid fa-bag-shopping"></i></a>
            <RouterLink :to="{name:'signInPage'}"><i class="fa-solid fa-user"></i></RouterLink>
        </div>
    </div>
</template>
<style>
     .HeaderCom{
        width: 93%;
        height: 75px;
        display: flex;
        align-items: center;
        margin: auto;
        justify-content: space-between;
        border-bottom: 0.5px solid #202020;
    }
    .Dropdown{
        display: flex;
        align-items: center;
        gap: 2rem;
        margin-right: 6rem;
    }
    .dropList{
        gap: 2rem;
    }
    .dropLink{
        font-size: 14px;
        color: black;
        font-family: "Dosis", sans-serif;
    }
    .dropLink:hover{
        color: goldenrod;
        transition: 0.3s;
    }
    .hMenu{
        display: flex;
    }
    .hMenu img{
        height: 100%;
    }
    .hIcon{
        display: flex;
        align-items: center;
        gap: 2rem;
    }
    .hIcon i{
        font-size: 22px;
        color: black;
    }
    .hIcon i:hover{
        color: crimson;
    }
    .sidepanel{
        width: 0;
        position: fixed;
        z-index: 1;
        height: 100vh;
        top: 0;
        right: 0;
        background-color:white;
        overflow-x: hidden;
        transition: 0.3s;
    }
    .header-panel{
        display: flex;
        align-items: center;
        justify-content: space-between;
        padding: 15px 30px;
    }
    .sidepanel p{
        display: flex;
        align-items: center;
        justify-content: center;
    }
    /* .total{
        color: black;
        border-radius: 10px;
        font-size: 18px;
        position: absolute;
        bottom: 10px; 
        left: 50%;
        transform: translateX(-50%);
    } */
    .sidepanel a{
        padding: 8px 8px 8px 32px;
        text-decoration: none;
        font-size: 25px;
        color: #818181;
        display: block;
        transition: 0.3s;
    } 
    .sidepanel a:hover{
        color: #f9b856;
    }
    #openbtn{
        font-size: 20px;
        cursor: pointer;
        color: #111;
        padding: 10px 15px;
        border: none;
    }
</style>

<script>
export default {
  data() {
    return {
      sidePanelWidth: '0',
      cartItems: []
    };
  },
  methods: {
    openNav(){
            const sidepanel = document.getElementById("mySidepanel");
            if (sidepanel){
                sidepanel.style.width = "450px";
                sidepanel.style.boxShadow = "10px 10px 10px 10px rgba(0, 0, 0, 0.6)";
                document.body.style.overflow = "hidden";
            }
        },
        closeNav(){
            const sidepanel = document.getElementById("mySidepanel");
            if (sidepanel) {
                sidepanel.style.width = "0";
                document.body.style.overflow = "auto";
            }
        }
    }
};
</script>