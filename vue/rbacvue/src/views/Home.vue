<template>
    <el-container>
        <el-header class="header">
            <el-row :gutter="20">
                <el-col :span="4">
                    权限管理系统
                </el-col>
                <el-col :span="3" :offset="16">
                    <el-button type="primary" icon="el-icon-edit" circle></el-button>
                    <el-button type="success" icon="el-icon-check" circle></el-button>
                    <el-button type="info" icon="el-icon-message" circle></el-button>
                </el-col>
            </el-row>
        </el-header>
        <el-container>
            <el-aside width="200px">
                <el-menu default-active="2" :router="true" class="el-menu-vertical-demo" @open="handleOpen" @close="handleClose">
                    <el-submenu index="1">
                        <template slot="title">
                            <i class="el-icon-location"></i>
                            <span>系统设置</span>
                        </template>
                        <el-menu-item index="/Admin">用户管理</el-menu-item>
                        <el-menu-item index="/Menu">菜单管理</el-menu-item>
                        <el-menu-item index="1-4-3">角色管理</el-menu-item>
                    </el-submenu>
                </el-menu>
            </el-aside>
            <el-main>
                <router-view/>
            </el-main>
        </el-container>
    </el-container>
</template>

<script>
    export default {
        name: 'RbacProjectUiHome',

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
                }]
            };
        },

        mounted() {

        },

        methods: {
            handleOpen(key, keyPath) {
                console.log(key, keyPath);
            },
            handleClose(key, keyPath) {
                console.log(key, keyPath);
            }
        },
    };
</script>

<style>
    .el-header {
        background-color: #28b8d0;
        color: #333;
        text-align: center;
        line-height: 60px;
    }

    .el-header .el-col-4 {
        font-size: 24px;
        color: #fff;
        font-weight: bold;
        text-align: left;
    }

    .el-aside {
        background-color: #fff;
        color: #333;
        text-align: left;
        border-right: 1px solid #ccc;
    }

    .el-main {
        background-color: #fff;
        color: #333;
        text-align: center;
        height: calc(100vh);
    }

    .el-menu {
        border: none;
    }

    body>.el-container {
        margin-bottom: 40px;
    }

    .el-container:nth-child(5) .el-aside,
    .el-container:nth-child(6) .el-aside {
        line-height: 260px;
    }

    .el-container:nth-child(7) .el-aside {
        line-height: 320px;
    }
</style>