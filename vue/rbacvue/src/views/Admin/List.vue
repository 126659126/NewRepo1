<template>
  <div>
    <el-button type="primary" @click="Add">添加用户</el-button>
    <el-table :data="tableData" style="width: 100%">
      <el-table-column prop="u_UserName" label="用户名" width="180">
      </el-table-column>
      <el-table-column prop="u_Name" label="姓名" width="180">
      </el-table-column>
      <el-table-column prop="u_Email" label="邮箱"> </el-table-column>
      <el-table-column prop="name" label="创建人"> </el-table-column>
      <el-table-column prop="addTime" label="创建时间"> </el-table-column>
      <el-table-column label="操作"> </el-table-column>
    </el-table>
    <el-dialog title="添加用户" :visible.sync="dialogFormVisible">
      <admin-add ref="adminAdd"></admin-add>
      <div slot="footer" class="dialog-footer">
        <el-button @click="dialogFormVisible = false">取 消</el-button>
        <el-button type="primary" @click="Save">确 定</el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
import { Query } from "@/api/admin";
import AdminAdd from "./AdminAdd";
export default {
  name: "RbacProjectUiList",
  components: {
    AdminAdd,
  },
  data() {
    return {
      tableData: [],
      dialogFormVisible: false,
      pagesecrit: {
        PageIndex: 1,
        pageSize: 2,
      },
      keywords: "",
      startTime: "",
      endTime: "",
    };
  },

  mounted() {
    this.Show();
  },

  methods: {
    Add() {
      this.dialogFormVisible = true;
    },
    Save() {
      this.$refs.adminAdd.SaveAdd();
      this.dialogFormVisible = false;
    },
    Show() {
      Query(this.pagesecrit).then((m) => {
        console.log(m);
        this.tableData = m.data.item2;
      });
    },
  },
};
</script>