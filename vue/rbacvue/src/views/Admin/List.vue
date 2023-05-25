<template>
    <div>
        <el-button type="primary" @click="Add">添加用户</el-button>
        <el-table :data="tableData" style="width: 100%">
            <el-table-column prop="date" label="日期" width="180">
            </el-table-column>
            <el-table-column prop="name" label="姓名" width="180">
            </el-table-column>
            <el-table-column prop="address" label="地址">
            </el-table-column>
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
    import AdminAdd from './AdminAdd';
    export default {
        name: 'RbacProjectUiList',
        components: {
            AdminAdd
        },
        data() {
            return {
                tableData: [{
                    date: '2016-05-02',
                    name: '王小虎',
                    address: '上海市普陀区金沙江路 1518 弄'
                }, {
                    date: '2016-05-04',
                    name: '王小虎',
                    address: '上海市普陀区金沙江路 1517 弄'
                }, {
                    date: '2016-05-01',
                    name: '王小虎',
                    address: '上海市普陀区金沙江路 1519 弄'
                }, {
                    date: '2016-05-03',
                    name: '王小虎',
                    address: '上海市普陀区金沙江路 1516 弄'
                }],
                dialogFormVisible: false
            };
        },

        mounted() {

        },

        methods: {
            Add() {
                this.dialogFormVisible = true;
            },
            Save(){
                this.$refs.adminAdd.SaveAdd();
            }
        },
    };
</script>