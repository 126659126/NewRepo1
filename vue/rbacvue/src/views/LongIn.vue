<template>
  <div class="loginMain">
    <el-row class="login">
      <el-col :span="8" :offset="8">
        <el-card class="loginForm">
          <div slot="header" class="clearfix">
            <span>用户登录</span>
          </div>
          <el-form
            :model="ruleForm"
            :rules="rules"
            ref="ruleForm"
            label-width="100px"
            class="demo-ruleForm"
          >
            <el-form-item label="用户名" prop="userName">
              <el-input v-model="ruleForm.userName"></el-input>
            </el-form-item>
            <el-form-item label="密码" prop="password">
              <el-input v-model="ruleForm.password" show-password></el-input>
            </el-form-item>
            <el-form-item label="验证码" prop="validateCode">
              <el-col :span="12">
                <el-input v-model="ruleForm.validateCode"></el-input>
              </el-col>
              <el-col :span="8" :offset="2">
                <img
                  src="data:image/gif;base64,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"
                />
              </el-col>
            </el-form-item>
            <el-form-item>
              <el-button type="primary" @click="submitForm('ruleForm')"
                >登录</el-button
              >
              <el-button @click="resetForm('ruleForm')">重置</el-button>
            </el-form-item>
          </el-form>
        </el-card>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import { Login } from "../api/admin";
export default {
  name: "RbacProjectUiLogin",

  data() {
    return {
      ruleForm: {
        userName: "",
        password: "",
        validateCode: "",
      },
      rules: {
        userName: [
          { required: true, message: "请输入用户名", trigger: "blur" },
        ],
        password: [{ required: true, message: "请输入密码", trigger: "blur" }],
      },
    };
  },

  mounted() {},

  methods: {
    submitForm(formName) {
      this.$refs[formName].validate((valid) => {
        if (valid) {
          Login(this.ruleForm).then((m) => {
            if (m.info < 2) {
              this.$message({
                message: m.message,
                type: "warning",
              });
            } else {
              this.$router.push("/");
            }
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
    resetForm(formName) {
      this.$refs[formName].resetFields();
    },
  },
};
</script>
<style>
.loginMain {
  height: 100%;
  background: url("../assets/loginbg.png");
  background-size: 100% 100%;
  background-repeat: no-repeat;
}

.loginForm {
  margin: 0 auto;
  margin-top: 13em;
}

.clearfix:before,
.clearfix:after {
  display: table;
  content: "";
}

.clearfix:after {
  clear: both;
}
</style>