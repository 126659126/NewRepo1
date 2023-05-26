<template>
  <div style="margin-right: 30px">
    <el-form
      :model="ruleForm"
      :rules="rules"
      ref="ruleForm"
      label-width="100px"
      class="demo-ruleForm"
    >
      <el-col :span="12">
        <el-form-item label="用户名" prop="U_UserName">
          <el-input v-model="ruleForm.U_UserName"></el-input>
        </el-form-item>
      </el-col>
      <el-col :span="12">
        <el-form-item label="密码" prop="U_Password">
          <el-input v-model="ruleForm.U_Password"></el-input>
        </el-form-item>
      </el-col>
      <el-col :span="12">
        <el-form-item label="姓名" prop="U_Name">
          <el-input v-model="ruleForm.U_Name"></el-input>
        </el-form-item>
      </el-col>
      <el-col :span="12">
        <el-form-item label="邮箱" prop="U_Email">
          <el-input v-model="ruleForm.U_Email"></el-input>
        </el-form-item>
      </el-col>
      <el-col :span="24">
        <el-form-item label="头像">
          <el-upload
            class="avatar-uploader"
            :action="uploadFileUrl"
            :show-file-list="false"
            :on-success="handleAvatarSuccess"
            :before-upload="beforeAvatarUpload"
          >
            <img v-if="imageUrl" :src="imageUrl" class="avatar" />
            <i v-else class="el-icon-plus avatar-uploader-icon"></i>
          </el-upload>
        </el-form-item>
      </el-col>
    </el-form>
  </div>
</template>

<script>
import { Add } from "@/api/admin";
export default {
  name: "RbacProjectUiAdminAdd",

  data() {
    return {
      ruleForm: {
        U_UserName: "",
        U_Password: "",
        U_Name: "",
        U_Email: "",
        U_Avatar: "",
      },
      rules: {
        U_UserName: [
          { required: true, message: "请输入用户名", trigger: "blur" },
        ],
        U_Password: [
          { required: true, message: "请输入密码", trigger: "blur" },
        ],
      },
      uploadFileUrl: `${process.env.VUE_APP_BASEURL}/UploadFile/Upload`,
      imageUrl: "",
    };
  },

  mounted() {},

  methods: {
    handleAvatarSuccess(res, file) {
      console.log(res, file);
      this.imageUrl = URL.createObjectURL(file.raw);
      this.ruleForm.U_Avatar = res;
    },
    beforeAvatarUpload(file) {
      const isJPG = file.type === "image/jpeg" || file.type === "image/png";
      const isLt2M = file.size / 1024 / 1024 < 20;

      if (!isJPG) {
        this.$message.error("上传头像图片只能是 JPG 格式!");
      }
      if (!isLt2M) {
        this.$message.error("上传头像图片大小不能超过 2MB!");
      }
      return isJPG && isLt2M;
    },
    SaveAdd() {
      this.$refs.ruleForm.validate((valid) => {
        if (valid) {
          Add(this.ruleForm).then((m) => {
            console.log(m);
            this.$message({
              message: "添加成功",
              type: "success",
            });
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
  },
};
</script>

<style>
.avatar-uploader .el-upload {
  border: 1px dashed #d9d9d9;
  border-radius: 6px;
  cursor: pointer;
  position: relative;
  overflow: hidden;
}

.avatar-uploader .el-upload:hover {
  border-color: #409eff;
}

.avatar-uploader-icon {
  font-size: 28px;
  color: #8c939d;
  width: 88px;
  height: 88px;
  line-height: 88px;
  text-align: center;
}

.avatar {
  width: 88px;
  height: 88px;
  display: block;
}
</style>