<template>
    <div class="Heade">
        <div class="left">
            <h2>Best city Guide</h2>
        </div>
        <div class="right">
            <ul class="Dropdown" type='none'>
                <li class="List"><a href="" class="Link">Ice-cream</a></li>
                <li class="List"><a href="" class="Link">Donut</a></li>
                <li class="List"><a href="" class="Link">Tea</a></li>
                <li class="List"><a href="" class="Link">Coffee</a></li>
            </ul>
        </div>
    </div>
</template>
<style scoped>
    .Heade{
        width: 100%;
        height: 90px;
        display: flex;
        align-items: center;
        padding: 0 50px;
        justify-content: space-between;
    }
    .left{
        height: 100%;
        display: flex;
        align-items: center;
        justify-content:flex-start;
    }
    .Dropdown{
        display: flex;
        gap: 1rem;
    }
    .right{
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: flex-end;
    }
    @media screen and (min-width:340px) and (max-width:580px){
        .Heade{
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
        }
    }
</style>