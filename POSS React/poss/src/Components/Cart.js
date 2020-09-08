import React, { Fragment } from 'react';
import { connect } from 'react-redux';
import { productQuantity, clearProducts } from '../actions/productQuantity';

import kidsBoots from '../images/kidswaterproofboots.jpg';
import handbag from '../images/ladies-handbags.jpg';
import vest from '../images/vest.jpg';

function Cart({basketProps, productQuantity, clearProducts}) {
    console.log('props ', basketProps);

    let productInCart = [];

    Object.keys(basketProps.products).forEach( function(item) {
            console.log(item);
            console.log(basketProps.products[item].inCart);
            if(basketProps.products[item].inCart){
                productInCart.push(basketProps.products[item])
            }
            console.log(productInCart);
    });


   // const productImages = [kidsBoots, handbag, vest];

    const productImages = (product) => {
        if(product.tagName === 'kidsBoots'){
            return kidsBoots;
        }
        else if(product.tagName === 'vest'){
            return vest;
        }
        else if(product.tagName === 'handbag'){
            return handbag;
        }
    }

    productInCart = productInCart.map(( product, index) => {
        console.log('The selected Product is :');
        console.log(product);
        console.log(index);

        return (
            <Fragment key={index}>
                  <div className='product'><ion-icon onClick = {() => clearProducts(product.tagName)} name="close-circle"></ion-icon> <img src={productImages(product)}/>
                                <span className="sm-hide">{product.name}</span>
                        </div>
                        <div className="price sm-hide">R{product.price},00</div>
                        <div className="quantity">
                            <ion-icon onClick = {() => productQuantity('decrease', product.tagName)} className="decrease" name="arrow-back-circle-outline"></ion-icon>
                                <span>{product.numbers}</span>
                            <ion-icon onClick = {() => productQuantity('increase', product.tagName)}  className="increase" name="arrow-forward-circle-outline"></ion-icon>
                        </div>
                        <div className="total">R{product.numbers * product.price},00</div>
            </Fragment>
        )
    })


    return (
        <div className="product-containers">
            <div className="product-header">
                <h5 className="product-title">PRODUCT</h5>
                <h5 className="price sm-hide">PRICE</h5>
                <h5 className="quantity">QUANTITY</h5>
                <h5 className="total">TOTAL</h5>
            </div>
            <div className="products">
                {productInCart}
            </div>

            <div className="basketTotalContainer">
                <h4 className="basketTotalTitle">Basket Total</h4>
                <h4 className="basketTotal">R{basketProps.cartCost},00</h4>
            </div>
        </div>
    );
}


const mapStateToProps = state => ({
    basketProps : state.basketState
})
export default connect( mapStateToProps, { productQuantity, clearProducts } )(Cart);