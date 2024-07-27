<template>
    <div class="upload-file">
        <h2>File Upload</h2>
        <input type="file" @change="onchangeSelectFile">
        <button @click="uploadFileHandler">Upload</button>
        <p v-if="message"> {{ message }}</p>
    </div>
</template>
<script>
import axios from 'axios';

    export default{
        data(){
            return{
                Selectedfile: null,
                message: "",
            }
        },
        methods:{
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
        }
    }
</script>