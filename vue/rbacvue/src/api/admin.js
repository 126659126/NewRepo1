import axios from '../utils/request';

export function Login(data) {
    return axios({
        method: 'post',
        url: '/UserTable/LoginAsunc',
        data
    });
}