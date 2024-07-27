<template>
  <div class="AdminloginForm">
    <div class="subLogin">
      <RouterLink :to="{ name: 'homePage' }">back</RouterLink>
      <form @submit.prevent="loginHandler" class="sublogform">
        <input v-model="username" type="email" placeholder="Email" /><br />
        <input v-model="password" type="password" placeholder="Password"/>
      </form>
      <button @click.prevent="loginHandler">Submit</button>
      <p style="color: crimson">{{ this.errorMessage }}</p>
    </div>
  </div>
</template>
<style scoped>
.AdminloginForm {
  width: 100%;
  height: 100vh;
  place-content: center;
  display: grid;
}
.subLogin {
  width: 400px;
  height: 500px;
  border-radius: 5px;
  background-color: aqua;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
}
.sublogform input {
  width: 150px;
  height: 30px;
  padding: 10px;
}
</style>
<script>
import axios from "axios";

export default {
  data() {
    return {
      username: "",
      password: "",
      errorMessage: "",
    };
  },
  methods: {
    loginHandler() {
      var req = {
        username: this.username,
        password: this.password,
      };
      axios
        .post("http://localhost:5147/api/login", req)
        .then((res) => {
          if (res.status == 200) {
            var data = res.data;
            localStorage.setItem("isLogin", "OK");
            localStorage.setItem("username", data.username);
            this.$router.push("/admin/dashboard");
          } else {
            this.errorMessage = "Wrong username and password";
          }
        })
        .catch((error) => {
          this.errorMessage = "Wrong username and password";
        });
    },
  },
};
</script>
