<script setup>
import axios from "axios";
import { RouterLink } from "vue-router";
</script>
<template>
  <div class="containSide">
    <div class="sidecon">
      <table border="1" style="width: 100%; border-collapse: collapse">
        <tr v-for="(el, indx) in productList" :key="indx">
          <td class="col">{{ el.id }}</td>
          <td class="col1">{{ el.title }}</td>
          <td class="col1">{{ el.price }}</td>
          <td class="col1">{{ el.description }}</td>
          <td class="col">{{ el.cat_id }}</td>
        </tr>
      </table>
    </div>
  </div>
</template>
<style scope>
.containSide {
  width: 78.5%;
  height: 81vh;
  position: fixed;
  right: 10px;
  bottom: 31px;
  overflow: scroll;
}
.sideconr {
  width: 100%;
}
.col {
  width: 10%;
  height: 40px;
  text-align: center;
}
.col1 {
  width: 27.1%;
  min-height: 40px;
  padding-left: 10px;
}
</style>
<script>
export default {
  data() {
    return {
      productList: [],
      message: "",
    };
  },
  mounted() {
    axios
      .get("http://localhost:5147/products")
      .then((res) => {
        var data = res.data;
        for (var el in data) {
          this.productList.push(data[el]);
        }
      })
      .catch((error) => {
        this.message = "Failed to list product" + error;
      });
  },
};
</script>
