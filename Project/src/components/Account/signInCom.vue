<template>
    <div class="loginForm">
        <div class="logForm">
            <RouterLink :to="{name:'homePage'}" class="logRouter"><i class="fa-solid fa-arrow-left-long"></i> Home</RouterLink>
            <h1>Sign in</h1>
            <form class="loginSide">
                <label style="color: white;">Email</label>
                <br>
                <input type="email" placeholder="email">
                <br>
                <br>
                <label style="color: white;">Password</label>
                <br>
                <input type="password" placeholder="password">
            </form>
            <button @click="Loghandler">Sign in</button>
            <RouterLink :to="{name:'signupPage'}" style="color: black;">Don't have an account? Sign up</RouterLink>
        </div>
    </div>
</template>
<style scoped>
    .loginForm{
        width: 100%;
        height: 100vh;
        display: grid;
        background-color: white;
        place-content: center;
    }
    .logRouter{
        position: absolute;
        left: 5px;
        top: 5px;
        border-radius: 2px;
        background-color: gainsboro;
        color: black;
        padding: 5px;
    }
    .logForm{
        height: 500px;
        width: 400px;
        display: flex;
        position: relative;
        flex-direction: column;
        display: flex;
        background-color: white;
        border: 1px solid gray;
        border-radius: 5px;
        align-items: center;
        justify-content: center;
        justify-content: space-evenly;
    }
    .logForm h1{
        color: black;
        font-weight: 100;
    }
    .logForm input{
        width: 300px;
        padding-left: 10px;
        border-radius: 5px;
        font-size: 16px;
        color: black;
        background-color: white;
        border: 1px solid #4E6A81;
        height: 35px
    }
    .logForm button{
        width: 200px;
        height: 35px;
        background-color: rgb(20, 148, 239);
        border: none;
        color: white;
        font-size: 16px;
        border-radius: 10px;
    }
</style>

<script>
    export default{
        methods:{
            Loghandler(){
                
            }
        }
    }
</script>