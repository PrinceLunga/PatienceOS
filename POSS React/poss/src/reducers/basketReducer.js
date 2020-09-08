import { ADD_PRODUCT_BASKET, GET_NUMBERS_BASKET, INCREASE_QUANTITY, DECREASE_QUANTITY, CLEAR_PRODUCT } from "../actions/type";

const initialState = {
    basketNumbers: 0,
    cartCost: 0,
    products: {
        kidsBoots: {
            name: 'Boots',
            tagName: 'kidsBoots',
            price: 150.00,
            numbers: 0,
            inCart: false
        },
        handbag: {
            name: 'HandBagsSet',
            tagName: 'handbag',
            price: 280.00,
            numbers: 0,
            inCart: false
        },
        vest: {
            name: 'GreyVest',
            tagName: 'vest',
            price: 180.00,
            numbers: 0,
            inCart: false
        }
    }
}

export default (state = initialState, action) => {
    let productSelected = "";
    switch(action.type){
        case ADD_PRODUCT_BASKET:
            productSelected = { ...state.products[action.payload]}
              
            productSelected.numbers += 1;
            productSelected.inCart = true;
            console.log('selected product ', productSelected);
            return {
                ...state,
                basketNumbers : state.basketNumbers + 1,
                cartCost : state.cartCost + state.products[action.payload].price,
                products : {
                     ...state.products,
                     [action.payload]: productSelected
                }
            }
        case GET_NUMBERS_BASKET:
            return {
                ...state
            }
        case INCREASE_QUANTITY:

            productSelected = { ...state.products[action.payload]}
            productSelected.numbers += 1;
            return {
                ...state,
                basketNumbers: state.basketNumbers + 1,
                cartCost: state.cartCost + state.products[action.payload].price,
                products: {
                    ...state.products,
                    [action.payload]: productSelected
                }

            }
        case DECREASE_QUANTITY:
            productSelected = { ...state.products[action.payload]};
            let newCartCost = 0;
            let decreasedBasketNumbers = 0;
            if(productSelected.numbers ===0){
                productSelected.numbers = 0;   
                newCartCost = state.cartCost; 
                decreasedBasketNumbers = state.basketNumbers;
            } else{
                productSelected.numbers -= 1;  
                newCartCost = state.cartCost - state.products[action.payload].price;
                decreasedBasketNumbers = state.basketNumbers - 1;   
            }
            //productSelected.numbers -= 1;
            return {
                ...state,   
                basketNumbers: decreasedBasketNumbers,
                cartCost:  newCartCost,
                products: {
                    ...state.products,
                    [action.payload]: productSelected
                }

            }
        case CLEAR_PRODUCT:
           productSelected = { ...state.products[action.payload]};
           let numbersCopy = productSelected.numbers;
           productSelected.numbers = 0;
           productSelected.inCart = false;
           
           return{
               ...state,
               basketNumbers: state.basketNumbers - numbersCopy,
               cartCost: state.cartCost - ( numbersCopy * productSelected.price ),
               products: {
                ...state.products,
                [action.payload]: productSelected
            }
           }
        default:
            return state;
    }
}