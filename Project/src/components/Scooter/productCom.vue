<template>
  <div class="Product">
    <div class="subBox" v-for="(el, indx) in productList" :key="indx">
      <div class="hidden">
        <button><i class="fa-solid fa-bag-shopping"></i></button>
        <button><i class="fa-solid fa-eye"></i></button>
      </div>
      <div class="subBox-img">
        <img :src="'../src/assets/img/' + el.image" />
      </div>
      <h3 style="margin-left: 10px;">{{ el.title }}</h3>
      <p style="margin-left: 10px; color: crimson">{{ el.price }}</p>
    </div>
  </div>
</template>
<style scoped>
.Product {
  width: 90%;
  padding: 10px 0;
  margin: auto;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  gap: 2rem;
}
.subBox {
  width: 280px;
  position: relative;
  height: 450px;
  background-color: #f5fbfb;
  overflow: hidden;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}
.subBox:hover .subBox-img img {
  transition: 1s;
  transform: scale(1.15);
}
.hidden {
  position: absolute;
  z-index: 99;
  right: -15%;
  top: 30px;
  width: 15%;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: 0.5s;
  flex-direction: column;
}
.hidden button {
  border: none;
  margin-top: 10px;
}
.hidden i {
  color: black;
  font-size: 18px;
}
.hidden i:hover {
  color: red;
}
.subBox:hover .hidden {
  right: 0;
  transition: 1s;
}
.subBox-img {
  overflow: hidden;
  width: 100%;
  height: 75%;
}
.subBox-img img {
  width: 100%;
  transition: 1s;
  height: 100%;
}
</style>
<script>
import axios from "axios";

export default {
  data() {
    return {
      productList: [],
      errorMessages: "",
    };
  },
  mounted() {
    var cat_id = this.$route.params.cat_id;
    axios
      .get("http://localhost:5147/products/list/" + cat_id)
      .then((res) => {
        if (res.status == 200) {
          var data = res.data;
          for (var el in data) {
            this.productList.push(data[el]);
          }
        }
      })
      .catch((err) => {
        this.errorMessages = "Can not read products." + err;
      });
  },
};
</script>
