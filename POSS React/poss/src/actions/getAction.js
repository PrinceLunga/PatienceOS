import { GET_NUMBERS_BASKET } from './type';

export const getNumbers = () => {
    return (dispatch) => {
        console.log('Getting all Basket numbers');
        dispatch({
            type: GET_NUMBERS_BASKET
        })
    }
}