import axios from "axios";
import GetProductsRequest from "./components/catalog/requests/GetProductsRequest";
import CategoryFilterView from "./components/views_/CategoryFilterView";
import ProductView from "./components/views_/ProductView";
import CategoryFullView from "./components/views_/CategoryFullView";

const MainLink = 'https://localhost:5001/api/';

const API = {

    GetAllCategories: () => {
        return axios
            .post<CategoryFullView[]>(MainLink + 'GetAllCategories')
            .then(res => res.data);
    },

    GetProducts: (info: GetProductsRequest) => {
        return axios
            .post<ProductView[]>(MainLink + 'GetProducts', info)
            .then(res => res.data);
    },

    GetCategoryFilters: (categoryId: number) => {
        return axios
            .post<CategoryFilterView[]>(MainLink + `GetCategoryFilters/${categoryId}`)
            .then(res => res.data);
    },

    SetProductOrderCount: (productId: number, count: number) => {
        return axios
            .post<void>(MainLink + `SetProductOrderCount/${productId}/${count}`)
            .then(res => res.data);
    },

}

export default API;
