import { INCREASE_QUANTITY, DECREASE_QUANTITY, CLEAR_PRODUCT } from './type';


export const productQuantity = (action, name) => {
    return (dispatch) => {
        console.log("Inside product Quantity");
        console.log("The action is ", action);
        console.log("The product is ", name);

        dispatch({
            type: action === 'increase' ? INCREASE_QUANTITY : DECREASE_QUANTITY,
            payload: name
        })
    }
}

export const clearProducts = (name) => {
    return (dispatch) => {
        console.log("Inside clear Products");
        console.log("The product is ", name);
        //console.log("The action is ", action);
        

        dispatch({
            type: CLEAR_PRODUCT,
            payload: name
        })
    }
}