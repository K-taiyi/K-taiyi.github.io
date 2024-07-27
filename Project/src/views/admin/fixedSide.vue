<template>
    <div class="leftSide" >
        <ul class="dropSide" type="none">
            <li class="sideList"><RouterLink to="" class="sideRouter"><i class="fa-solid fa-display"></i>Costomer</RouterLink></li>
            <li class="sideList"><RouterLink to="" class="sideRouter"><i class="fa-solid fa-display"></i>Employee</RouterLink></li>
            <li class="sideList"><RouterLink to="" class="sideRouter"><i class="fa-solid fa-display"></i>POS</RouterLink></li>
            <li class="sideList"><RouterLink to="" class="sideRouter"><i class="fa-solid fa-users"></i>Product</RouterLink></li>
            <li class="sideList"><RouterLink to="" class="sideRouter">Category</RouterLink></li>
            <li class="sideList"><RouterLink to="" class="sideRouter">Role</RouterLink></li>
            <li class="sideList"><button @click="logoutHandler" class="sideRouter" style="position: absolute; bottom: 0;"><i class="fa-solid fa-display"></i>Logout</button></li>
        </ul>
    </div>
</template>
<style scope>
    .leftSide{
        width: 20%;
        height: 100vh;
        background-color: rgb(3, 9, 30);
        position: fixed;
        left: 0;
    }
    .sideRouter{
        padding: 15px;
        display: inline-block;
        width: 100%;
        color: black;
        border-bottom: 1px solid seagreen;
        background-color: gainsboro;
    }
    .sideRouter:hover{
        background-color: white;
    }
    .sideRouter i{
        margin-right: 10px;
    }
</style>
<script>
    export default{
        methods: {
            logoutHandler(){
                localStorage.removeItem("isLogin");
                this.$router.push('/admin/Login');
            }
        }
    }
</script>