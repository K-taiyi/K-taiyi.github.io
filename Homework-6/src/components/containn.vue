<template>
    <div class="Containe">
        <div class="Box1">
            <h2>Welcome!</h2>
            <br>
            <p>Everything in this city is worth waiting inline for.</p>
            <br>
            <p>Cupcake ipsum dolor sit. Amet chocolate cake gummies jelly beans candy bonbon brownie candy. Gingerbread powder muffin. Icing cotton candy. Croissant icing pie ice cream brownie I love cheesecake cookie. Pastry chocolate pastry jelly croissant.</p>
            <br>
            <p>Cake sesame snaps sweet tart candy canes tiramisu I love oat cake chocolate bar. Jelly beans pastry brownie sugar plum pastry bear claw tiramisu tootsie roll. Tootsie roll wafer I love chocolate donuts.</p>
        </div>
        <div class="Box2">
            <h2>Great Food</h2>
            <img src="../assets/food.svg" alt="">
            <p>Croissant macaroon pie brownie. Cookie marshmallow liquorice gingerbread caramels toffee I love chocolate.Wafer lollipop dessert. Bonbon jelly beans pudding dessert sugar plum. Marzipan toffee dragée chocolate bar candy toffee pudding I love. Gummi bears pie gingerbread lollipop.</p>
        </div>
        <div class="Box3">
            <h2>How to get here</h2>
            <br>
            <p>Plane: Tiramisu caramels gummies chupa chups lollipop muffin. Jujubes chocolate caramels cheesecake brownie lollipop dragée cheesecake.</p>
            <br>
            <br>
            <p>Train: Pie apple pie pudding I love wafer toffee liquorice sesame snaps lemon drops. Lollipop gummi bears dessert muffin I love fruitcake toffee pie.</p>
            <br>
            <br>
            <p>Car: Jelly cotton candy bonbon jelly-o jelly-o I love. I love sugar plum chocolate cake pie I love pastry liquorice.</p>
        </div>
    </div>
</template>

<style scoped>
    .Containe{
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        padding: 40px;
        line-height: 1.24;
        gap: 1rem;
        font-size: 20px;
        justify-content: space-around;
    }
    .Box1 , .Box2 , .Box3{
         width: 400px;
    }
    @media screen and (min-width:550px) and (max-width:800px){
        .Containe{
            display: flex;
            align-items: center;
            
            padding: 20px 0;
            justify-content: center;
        }
        .Box1 ,.Box2 ,.Box3{
            width: 500px;
        }
    }
    @media screen and (min-width:801px) and (max-width:1000px){
        .Containe{
            padding: 20px 0;
            display: flex;
        }
        .Box1{
            width: 390px;
        }
        .Box2{
            width: 390px;
        }
        .Box3{
            padding: 0 20px;
            width: 100%;
        }
    }
    @media screen and (min-width:1001px) and (max-width:1400px){
        .Box1 , .Box2 , .Box3{
            width: 30%;
       }
    }
</style>