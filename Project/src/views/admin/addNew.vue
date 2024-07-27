<template>
  <div class="conAddnewProduct">
    <div class="AddNewProduct">
      <h1>Add new product</h1>
      <form>
        <input class="newInput" type="text" id="txt_title" placeholder="Product_name" v-model="title" required/>
        <br/><br/>
        <input class="newInput" type="text" placeholder="Description" v-model="description" required/>
        <br/><br/>
        <input class="newInput" type="text" placeholder="Price" v-model="price" required/>
        <br/><br/>
        <input class="newInput" type="text" placeholder="Category_id"  v-model="cat_id" required/>
        <br/><br/>
        <input type="file"
         @change="onchangeSelectFile">
      </form>
      <div class="btn_save">
        <RouterLink class="save_rout" :to="{ name:'adminPage'}">Cancel</RouterLink>
        <button @click="addUser">Save</button>
        {{ errorMessage }}
      </div>
    </div>
  </div>
</template>
<style scoped>
    .conAddnewProduct {
    width: 100%;
    place-content: center;
    display: grid;
    height: 100vh;
    background-color: aliceblue;
    }
    .AddNewProduct {
    width: 400px;
    height: 450px;
    border: 1px solid gray;
    border-radius: 5px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    padding: 20px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    }
    .newInput {
    width: 100%;
    height: 40px;
    padding: 10px;
    }
    .btn_save {
    width: 100%;
    display: flex;
    align-items: end;
    justify-content: end;
    }
    .btn_save button{
        padding: 5px;
        margin-left: 10px;
    }
    .save_rout {
    border: 1px solid black;
    padding: 5px;
    color: black;
    }
    .save_rout:hover {
    background-color: gainsboro;
    }
</style>
<script>
import axios from "axios";

export default {
  data() {
    return {
      title: "",
      price: "",
      description: "",
      image: "",
      cat_id: "",
    };
  },
  methods: {
    addUser() {
      var req = {
        title: this.title,
        price: this.price,
        description: this.description,
        cat_id : this.cat_id,
        image : "",
      };
      axios
        .post("http://localhost:5147/products/create", req)
        .then((res) => {
          if (res.status == 200) {
            this.errorMessage = "Success create user.";

            //clear
            this.title = "";
            this.price = "";
            this.description = "";
            this.cat_id = "";
            this.$router.push("/admin/dashboard");
          } else {
            this.errorMessage = "Error create user";
          }
        })
        .catch((err) => {
          this.errorMessage = "Error create user";
        });
    },
    onchangeSelectFile(event){
          this.Selectedfile = event.target.files[0];
      },
      uploadFileHandler(){
          if(this.Selectedfile == null){
              this.message= "Please selete File";
              return 
          }
          var formData = new FormData();
          formData.append("file",this.Selectedfile)
          var header = {
              'Content-Type: ': 'multipart/form-data'
          }
          axios.post("http://localhost:5147/products/upload",
          formData,header).then((res) => {
              this.message= 'Successfully uploaded -'
          })
          .catch((error)=>{
              this.message = "can not upload file" + error
          })
      }
  },
};
</script>
