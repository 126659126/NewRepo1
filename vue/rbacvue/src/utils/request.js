import axios from 'axios';
import { MessageBox, Message } from 'element-ui'

axios.defaults.baseURL = process.env.VUE_APP_BASEURL;




// 添加请求拦截器
axios.interceptors.request.use(function (config) {
  // 在发送请求之前做些什么
  return config;
}, function (error) {
  // 对请求错误做些什么
  return Promise.reject(error);
});


axios.interceptors.response.use(function (response) {
  // 对响应数据做点什么
  //return response;

  const res = response.data

  // if the custom code is not 20000, it is judged as an error.
  if (res.code !== 200) {
    Message({
      message: res.message || 'Error',
      type: 'error',
      duration: 5 * 1000
    })
    return Promise.reject(new Error(res.message || 'Error'))
  } else {
    return res
  }

}, function (error) {
  // 对响应错误做点什么
  return Promise.reject(error);
});

export default axios;