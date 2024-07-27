<template>
    <div class="onSide">
        <div class="adminLogo">
            <p>Admin_name and Logo</p>
            <div class="onrout">
                <RouterLink :to="{name:''}" class="btnNew1">Delete</RouterLink>
                <RouterLink class="btnNew" :to="{name:'AddNewProduct'}">New</RouterLink>
            </div>
        </div>
        <div class="adminSearch">
            <table class="tbl_form">
                <tr>
                    <th class="row1">ID</th>
                    <th class="row2">Name</th>
                    <th class="row3">Price</th>
                    <th class="row4">Description</th>
                    <th class="row1">Category</th>
                </tr>
            </table>
        </div>
    </div>
</template>
<style scope>
    .onSide{
        width: 80%;
        position: fixed;
        background-color: gainsboro;
        top: 0;
        right: 0;
    }
    .adminLogo{
        display: flex;
        align-items: center;
        justify-content: space-between;
        padding: 10px;
    }
    .btnNew{
        padding: 10px 15px;
        border-radius: 5px;
        color: white;
        background-color: blue;
    }
    .btnNew:hover{
        background-color: #00009b;
    }
    .btnNew1{
        padding: 10px 15px;
        border-radius: 5px;
        color: white;
        background-color: crimson;
    }
    .btnNew1:hover{
        background-color: #a70525;
    }
    .onrout{
        display: flex;
        width: 150px;
        justify-content: space-between;
    }
    .adminSearch{
        width: 100%;
        padding: 10px;
    }
    .adminSearch input{
        width: 250px;
        height: 35px;
        padding-left: 10px;
    }
    .tbl_form{
        width: 100%;
        border-collapse: collapse;
    }
    .row1{
        width: 10%;
        border: 1px solid black;
    }
    .row2{
        width: 27.1%;
        border: 1px solid black;
    }
    .row3{
        width: 27.1%;
        border: 1px solid black;
    }
    .row4{
        width: 27%;
        border: 1px solid black;
    }
</style>