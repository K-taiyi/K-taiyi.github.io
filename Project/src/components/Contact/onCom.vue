<template>
    <div class="cContact">
       <div class="contactBox">
            <div class="onBox">
                <h1>Contact us</h1>
                <h2>If you have any questions, please feel free to get in touch with us, we’ll get back to you shortly.</h2>
            </div>
            <div class="bottomBox">
                <div class="boxForm">
                    <div class="boxForm-child">
                        <label for="inputName" class="form-label">Full Name</label><br>
                        <input type="text" placeholder="full name" class="form-control">
                    </div>
                    <div class="boxForm-child">
                        <label for="inputEmail" class="form-label">Email Address</label><br>
                        <input type="email" placeholder="email address" class="form-control">
                    </div>
                    <div class="boxForm-child">
                        <label for="inputPhone" class="form-label">Phone number</label><br>
                        <input type="number" placeholder="phone number" class="form-control">
                    </div>
                    <div class="boxForm-child">
                        <label for="inputSub" class="form-label">Subject</label><br>
                        <input type="text" placeholder="subject" class="form-control">
                    </div>
                    
                </div>
                <div class="boxArea-child">
                    <label for="inputMessage" class="form-label">Message</label><br>
                    <textarea name="InputMess" placeholder="message" class="form-area"></textarea>
                </div>
            </div>
            <a href="" class="Bmessage">SEND MESSAGE<i class="fa-solid fa-arrow-right-long"></i></a>
       </div>
    </div>
</template>
<style scoped>
    .cContact{
        width: 100%;
        height: 140vh;
        display: flex;
        place-content: center;
        justify-content: space-evenly;
        background-color: aquamarine;
    }
    .contactBox{
        width: 85%;
        height: 120vh;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: space-evenly;
    }
    .onBox{
        width: 48%;
        margin: auto;
        text-align: center;
    }
    .onBox h1{
        font-size: 60px;
        margin-bottom: 30px;
    }
    .onBox h2{
        font-size: 30px;
    }
    .boxForm{
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        justify-content: space-between;
    }
    .boxForm-child{
        width: 550px;
    }
    .form-label{
        font-size: 16px;
        line-height: 2rem;
        color: black;
    }
    .form-control{
        display: block;
        width: 100%;
        height: 52px;
        margin: 10px 0;
        border: none;
        background-color: #ececec;
        border-radius: 5px;
        padding: 0 10px;
        font-size: 16px;
    }
    .form-area{
        width: 100%;
        height: 140px;
        border: none;
        border-radius: 5px;
        padding: 15px;
        font-size: 16px;
        background-color: #ececec;
    }
    .Bmessage{
        padding: 20px;
        background-color: rgb(190, 19, 53);
        color: white;
        border-radius: 5px;
        margin-top: 20px;
    }
    .Bmessage i{
        margin-left: 10px;
    }
    .Bmessage:hover{
        background-color: rgb(21, 21, 78);
    }
</style>