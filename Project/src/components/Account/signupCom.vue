<template>
    <div class="conForm">
        <div class="subForm">
            <RouterLink :to="{name:'homePage'}" class="formRouter"><i class="fa-solid fa-arrow-left-long"></i> Home</RouterLink>
            <h1>Create your account</h1>
            <form class="signForm">
                <input type="email" placeholder="Email">
                <br>
                <br>
                <input type="text" placeholder="Username">
                <br>
                <br>
                <input type="number" placeholder="Phone Number">
                <br>
                <br>
                <input type="password" placeholder="Password">
            </form>
            <button>Sign up</button>
            <RouterLink :to="{name:'signInPage'}" style="color: white;">Already have an account? Sign in</RouterLink>
        </div>
    </div>
</template>
<style scoped>
    .formRouter{
        position: absolute;
        left: 5px;
        top: 5px;
        border-radius: 2px;
        background-color: #80808083;
        color: gainsboro;
        padding: 5px;
    }
    .conForm{
        width: 100%;
        height: 100vh;
        display: grid;
        background-color: #141B1F;
        place-content: center;
    }
    .subForm{
        height: 600px;
        width: 480px;
        display: flex;
        position: relative;
        flex-direction: column;
        display: flex;
        background-color: #1C262D;
        align-items: center;
        justify-content: center;
        justify-content: space-evenly;
    }
    .subForm h1{
        color: white;
    }
    .subForm button{
        width: 320px;
        height: 35px;
        background-color: rgb(20, 148, 239);
        border: none;
        color: white;
        font-size: 16px;
        border-radius: 10px;
    }
    .signForm input{
        width: 370px;
        padding-left: 10px;
        color: #ADBDCB;
        background-color: #141B1F;
        border: 1px solid #4E6A81;
        height: 35px
    }
</style>