import axios from '../utils/request';

export function Login(data) {
    return axios({
        method: 'post',
        url: '/UserTable/LoginAsunc',
        data
    });
}

export function Add(data) {
    return axios({
        method: 'post',
        url: '/UserTable/Create',
        data
    });
}

export function Query(params) {
    return axios({
        method: 'get',
        url: '/UserTable/PageDataTuple',
        params
    });
}